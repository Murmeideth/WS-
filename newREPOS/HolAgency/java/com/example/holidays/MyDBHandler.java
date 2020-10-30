package com.example.holidays;

import android.app.Activity;
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
    public static final String COLUMN_ID = "ID_event";
    public static final String COLUMN_NAME = "Name_event";
    public static final String COLUMN_DESCRIPTION = "Description_event";
    public static final String COLUMN_EMPLOYER = "Emp_event";
    public static final String COLUMN_DATE = "Date_event";
    public static final String COLUMN_DOCUMENTS = "Document_event";

    public MyDBHandler(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String CREATE_TABLE = "CREATE TABLE " + TABLE_NAME + " (" + COLUMN_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, " + COLUMN_NAME + " TEXT, " + COLUMN_DESCRIPTION + " TEXT, " + COLUMN_EMPLOYER + " TEXT, " + COLUMN_DATE + " DATE, " + COLUMN_DOCUMENTS + "TEXT)";
        db.execSQL(CREATE_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1) {

    }

    public String loadHandler() {
        String result = "";
        String query = "SELECT * FROM " + TABLE_NAME;
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(query, null);
        while (cursor.moveToNext())
        {
            int result_0 = cursor.getInt(0);
            String result_1 = cursor.getString(1);
            String result_2 = cursor.getString(2);
            String result_3 = cursor.getString(3);
            String result_4 = cursor.getString(4);
            String result_5 = cursor.getString(5);
            result += String.valueOf(result_0) + " " + result_1 + " " + result_2 + " " + result_3 + " " + result_4 + " " + result_5 + System.getProperty("line.separator");
        }
        cursor.close();
        db.close();

        return result;
    }
    public void addHandler(main main){
        ContentValues values = new ContentValues();
        values.put(COLUMN_ID, main.getID());
        values.put(COLUMN_NAME, main.getNaming());
        values.put(COLUMN_DESCRIPTION, main.getDescription());
        values.put(COLUMN_EMPLOYER, main.getEmp());
        values.put(COLUMN_DATE, main.getDate());
        values.put(COLUMN_DOCUMENTS, main.getDoc());
        SQLiteDatabase db = this.getWritableDatabase();
        db.insert(TABLE_NAME, null, values);
        db.close();
    }

    public void addEmp(employers employers){
        ContentValues values = new ContentValues();
        values.put(COLUMN_ID, employers.getID());
        values.put(COLUMN_NAME, employers.getNaming());
        values.put(COLUMN_DESCRIPTION, employers.getDescription());
        values.put(COLUMN_EMPLOYER, employers.getPosition());
        SQLiteDatabase db = this.getWritableDatabase();
        db.insert(TABLE_NAME, null, values);
        db.close();
    }

    public void addDoc(documents documents){
        ContentValues values = new ContentValues();
        values.put(COLUMN_ID, documents.getID());
        values.put(COLUMN_NAME, documents.getNaming());
        values.put(COLUMN_DESCRIPTION, documents.getDescription());
        SQLiteDatabase db = this.getWritableDatabase();
        db.insert(TABLE_NAME, null, values);
        db.close();
    }


    public boolean deleteHandler(int ID) {
        boolean result = false;
        String query = "Select * from " + TABLE_NAME + "where " + COLUMN_ID + "= '" + String.valueOf(ID) + "'";
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(query, null);
        main main = new main();
        if (cursor.moveToFirst())
        {
            main.setID((Integer.parseInt(cursor.getString(0))));
            db.delete(TABLE_NAME, COLUMN_ID + "=?", new String[]{
               String.valueOf(main.getID())
            });
            cursor.close();
            result = true;
        }
        db.close();
        return result;
    }
}
