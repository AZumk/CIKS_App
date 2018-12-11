using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;

namespace App_CIKS.Activities
{
    [Activity(Label = "SQLiteHelper")]
    public class SQLiteHelper : SQLiteOpenHelper
    {
        private static String Progresso = "Progresso.db";
        //
        public String ID = "id";
        public String DesafiosRespondidos = "respondidos";
        public String DesafiosCorretos = "corretos";
        public String DesafiosIncorretos = "incorretos";
        //constructor to create database


        public SQLiteHelper(Context context)
            : base(context, Progresso, null, 2)
        {

        }

        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL(
                "create table Progresso " +
                "(id integer primary key, DesafiosRespondidos text, DesafiosCorretos text,DesafiosIncorretos text)"
                );
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            db.ExecSQL("");
            OnCreate(db);
        }

        // insert data

        public bool insertProgresso(int id, int DesafiosRespondidos, int DesafiosCorretos, int DesafiosIncorretos)
        {//isso na verdade foi aqui
            SQLiteDatabase db = this.WritableDatabase; //oq?
            ContentValues contentValues = new ContentValues();
            contentValues.Put("respondidos", DesafiosRespondidos);
            contentValues.Put("corretos", DesafiosCorretos);
            contentValues.Put("incorretos", DesafiosIncorretos);

            db.Insert("Progresso", null, contentValues);
            return true;
        }


        // get complete data/info

        public System.Collections.ArrayList getAllProgressoData()
        {
            System.Collections.ArrayList array_list = new System.Collections.ArrayList();

            //hp = new HashMap();
            SQLiteDatabase db = this.ReadableDatabase;
            ICursor res = db.RawQuery("select * from Progresso", null);
            res.MoveToFirst();

            while (res.IsAfterLast == false)
            {
                array_list.Add(res.GetString(res.GetColumnIndex(DesafiosRespondidos)));
                res.MoveToNext();
            }
            return array_list;
        }

        // get single entry
        public ICursor getSingleEntry(int id)
        {
            SQLiteDatabase db = this.ReadableDatabase;
            ICursor res = db.RawQuery("select * from Progresso where id=" + id + "", null);
            return res;
        }
        // delete entry
        public int deleteData(int id) //deletar
        {
            SQLiteDatabase db = this.WritableDatabase;
            return db.Delete("Progresso",
            "id = ? ", new String[] { Convert.ToString(id) }); //esse aqui deixava pre-definidos metodos do sqlite
        }
        // update entry
        public bool updateProgressoInfo(int id, int DesafiosRespondidos, int DesafiosCorretos, int DesafiosIncorretos) //update
        {
            SQLiteDatabase db = this.WritableDatabase;
            ContentValues contentValues = new ContentValues();
            contentValues.Put("respondidos", DesafiosRespondidos);
            contentValues.Put("corretos", DesafiosCorretos);
            contentValues.Put("incorretos", DesafiosIncorretos);

            db.Update("Progresso", contentValues, "id = ? ", new String[] { Convert.ToString(id) });
            //Java.Lang.RuntimeException: no such column: DesafiosCorretos (code 1): , while compiling: UPDATE Progresso SET DesafiosCorretos=?,DesafiosRespondidos=?,DesafiosIncorretos=? WHERE id = ?
            return true;
        }
    }
}