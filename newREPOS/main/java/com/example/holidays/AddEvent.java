package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class AddEvent extends AppCompatActivity implements View.OnClickListener{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_event);
        Button Add_done = (Button)findViewById(R.id.add_done);
        Button Add_back = (Button) findViewById(R.id.add_back);
        Add_back.setOnClickListener(this);
        Add_done.setOnClickListener(this);
    }

    public EditText id_ev = (EditText) findViewById(R.id.ID_event);
    public EditText name_ev = (EditText) findViewById(R.id.Name_event);
    public EditText desc_ev = (EditText) findViewById(R.id.Desc_event);
    public EditText emp_ev = (EditText) findViewById(R.id.Emplo_event);
    public EditText date_ev = (EditText) findViewById(R.id.Date_event);
    public EditText doc_ev = (EditText) findViewById(R.id.Doc_event);

    public void addInfo() {
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        int id = Integer.parseInt(id_ev.getText().toString());
        String name = name_ev.getText().toString();
        String desc = desc_ev.getText().toString();
        String empl = emp_ev.getText().toString();
        String date = date_ev.getText().toString();
        String docs = doc_ev.getText().toString();
        main main = new main(id, name, desc, empl, date, docs);
        dbHandler.addHandler(main);
        id_ev.setText("");
        name_ev.setText("");
        desc_ev.setText("");
        emp_ev.setText("");
        date_ev.setText("");
        doc_ev.setText("");
    }

    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view) {
        switch(view.getId())
        {
            case R.id.add_done:
                addInfo();
                Intent Intent_done = new Intent (this, MainActivity.class);
                startActivity(Intent_done);
                break;

            case R.id.add_back:
                Intent Intent_back = new Intent(this, MainActivity.class);
                startActivity(Intent_back);
                break;

            default:
                break;

        }
        }
    }


