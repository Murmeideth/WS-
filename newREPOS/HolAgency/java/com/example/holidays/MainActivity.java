package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.text.BreakIterator;
import java.text.StringCharacterIterator;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    TextView Field = (TextView) findViewById(R.id.MainField);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button Add = (Button) findViewById(R.id.add_event);
        Add.setOnClickListener(this);
    }


    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view){
        switch (view.getId()) {
            case R.id.add_event:
                Intent ADD = new Intent(this, AddEvent.class);
                startActivity(ADD);
                break;

            case R.id.delete_button:
                Intent Delete = new Intent(this, Delete_event.class);
                startActivity(Delete);
                break;

            case R.id.Docs_button:
                Intent Documents = new Intent(this, DocList.class);
                startActivity(Documents);
                break;

            case R.id.Employers_button:
                Intent Employers = new Intent(this, EmploList.class);
                startActivity(Employers);
                break;

            default:
                break;
        }
    }

    public void loadInfo(View view) {
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        Field.setText(dbHandler.loadHandler());
    }



}