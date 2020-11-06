package com.example.studuchet;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;


public class MyDBHandler extends SQLiteOpenHelper {

    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "Holiday_Agency";
    public static final String TABLE_NAME = "main";
    public static final String COLUMN_ID = "ID_stud";
    public static final String COLUMN_NAME = "Name_stud";
    public static final String COLUMN_GROUP = "Group_stud";
    public static final String COLUMN_CURATOR = "Curator_stud";

    public static final String TABLE_NAME_GROUP = "groups";
    public static final String COLUMN_ID_GROUP = "ID_group";
    public static final String COLUMN_NAME_GROUP = "Code_group";
    public static final String COLUMN_DESCRIPTION_GROUP = "Desc_group";

    public static final String TABLE_NAME_CURATOR = "curator";
    public static final String COLUMN_ID_CURATOR = "ID_cur";
    public static final String COLUMN_NAME_CUR = "Name_cur";
    public static final String COLUMN_POSITION_CUR = "Position_cur";

    public MyDBHandler(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String CREATE_TABLE = "CREATE TABLE " + TABLE_NAME + "(" + COLUMN_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, " + COLUMN_NAME + " TEXT, " + COLUMN_GROUP + " TEXT, " + COLUMN_CURATOR + " TEXT)";
        String CREATE_TABLE_GROUP = "CREATE TABLE " + TABLE_NAME_GROUP + "(" + COLUMN_ID_GROUP + " INTEGER," + COLUMN_NAME_GROUP + " TEXT, " + COLUMN_DESCRIPTION_GROUP + " TEXT)";
        String CREATE_TABLE_CURATOR = "CREATE TABLE " + TABLE_NAME_CURATOR + "(" + COLUMN_ID_CURATOR + " INTEGER, " + COLUMN_NAME_CUR + "T EXT, " + COLUMN_POSITION_CUR + " TEXT)";

        db.execSQL(CREATE_TABLE);
        db.execSQL(CREATE_TABLE_GROUP);
        db.execSQL(CREATE_TABLE_CURATOR);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public String loadHandler(String TABLE) {
        String result = "";
        String query = "SELECT * FROM " + TABLE;
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(query, null);
        if (TABLE == "main") {
            while (cursor.moveToNext())
            {
                int result_0 = cursor.getInt(0);
                String result_1 = cursor.getString(1);
                String result_2 = cursor.getString(2);
                String result_3 = cursor.getString(3);
                result += String.valueOf(result_0) + " " + result_1 + " " + result_2 + " " + result_3 + System.getProperty("line.separator");
            }
        }else if (TABLE == "groups") {
                while (cursor.moveToNext()){
                 int result_0 = cursor.getInt(0);
                 String result_1 = cursor.getString(1);
                 String result_2 = cursor.getString(2);
                 result += String.valueOf(result_0) + " " + result_1 + " " + result_2 + System.getProperty("line.separator");
                }
        }else if (TABLE == "curator") {
            while (cursor.moveToNext()){
                int result_0 = cursor.getInt(0);
                String result_1 = cursor.getString(1);
                String result_2 = cursor.getString(2);
                result += String.valueOf(result_0) + " " + result_1 + " " + result_2 + System.getProperty("line.separator");
            }
        }
        cursor.close();
        db.close();

        return result;
    }

    public void addHandler(main main, groups groups, curator curator, String TABLE) {
        if (TABLE == "main") {
            ContentValues values = new ContentValues();
            values.put(COLUMN_ID, main.getID_stud());
            values.put(COLUMN_NAME, main.getName_stud());
            values.put(COLUMN_GROUP, main.getGroup_stud());
            values.put(COLUMN_CURATOR, main.getCurator_stud());
            SQLiteDatabase db = this.getWritableDatabase();
            db.insert(TABLE_NAME, null, values);
            db.close();
        } else if (TABLE == "groups") {
            ContentValues values = new ContentValues();
            values.put(COLUMN_ID_GROUP, groups.getID_group());
            values.put(COLUMN_NAME_GROUP, groups.getCode_group());
            values.put(COLUMN_DESCRIPTION_GROUP, groups.getDescription_group());
            SQLiteDatabase db = this.getWritableDatabase();
            db.insert(TABLE_NAME_GROUP, null, values);
            db.close();
        } else if (TABLE == "curator") {
            ContentValues values = new ContentValues();
            values.put(COLUMN_ID_CURATOR, curator.getID_cur());
            values.put(COLUMN_NAME_CUR, curator.getName_cur());
            values.put(COLUMN_POSITION_CUR, curator.getPosition_cur());
            SQLiteDatabase db = this.getWritableDatabase();
            db.insert(TABLE_NAME_CURATOR, null, values);
            db.close();
        }
    }

    public boolean deleteHandler(int ID, String TABLE){
        boolean result = false;
        if (TABLE == "main"){
            String query = "Select * from " + TABLE_NAME + "where " + COLUMN_ID + "= '" + String.valueOf(ID) + "'";
            SQLiteDatabase db = this.getWritableDatabase();
            Cursor cursor = db.rawQuery(query, null);
            main main = new main();
            if(cursor.moveToFirst()){
                main.setID_stud(Integer.parseInt(cursor.getString(0)));
                db.delete(TABLE_NAME, COLUMN_ID + "=?", new String[]{
                        String.valueOf(main.getID_stud())
                });
                cursor.close();
                result = true;
            }
        }
        else if (TABLE == "groups"){
            String query = "Select * from " + TABLE_NAME_GROUP + "where " + COLUMN_ID_GROUP + "= '" + String.valueOf(ID) + "'";
            SQLiteDatabase db = this.getWritableDatabase();
            Cursor cursor = db.rawQuery(query, null);
            groups groups = new groups();
            if(cursor.moveToFirst()){
                groups.SetID_group(Integer.parseInt(cursor.getString(0)));
                db.delete(TABLE_NAME_GROUP, COLUMN_ID_GROUP + "=?", new String[]{
                        String.valueOf(groups.getID_group())
                });
                cursor.close();
                result = true;
            }

        }else if (TABLE == "curator"){
            String query = "Select * from " + TABLE_NAME_CURATOR + "where " + COLUMN_ID_CURATOR + "= '" + String.valueOf(ID) + "'";
            SQLiteDatabase db = this.getWritableDatabase();
            Cursor cursor = db.rawQuery(query, null);
            curator curator = new curator();
            if(cursor.moveToFirst()){
                curator.SetID_cur(Integer.parseInt(cursor.getString(0)));
                db.delete(TABLE_NAME_CURATOR, COLUMN_ID_CURATOR + "=?", new String[]{
                        String.valueOf(curator.getID_cur())
                });
                cursor.close();
                result = true;
            }
        }
        return result;
    }
}

