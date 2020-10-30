package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class Doc_add extends AppCompatActivity implements View.OnClickListener{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doc_add);
    }

    public EditText id_dc = (EditText) findViewById(R.id.ID_doc_add);
    public EditText name_dc = (EditText) findViewById(R.id.Name_doc_add);
    public EditText desc_dc = (EditText) findViewById(R.id.Disc_doc_add);
    public void addInfoEmp(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        int id = Integer.parseInt(id_dc.getText().toString());
        String name = name_dc.getText().toString();
        String desc = desc_dc.getText().toString();
        documents documents = new documents(id, name, desc);
        dbHandler.addDoc(documents);
        id_dc.setText("");
        name_dc.setText("");
        desc_dc.setText("");
    }

    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view){
        switch (view.getId()){

            case R.id.Back_doc_add:
                Intent BDoc = new Intent(this, DocList.class);
                startActivity(BDoc);
                break;

            case R.id.Add_doc_add:
                addInfoEmp();
                Intent AddDoc = new Intent(this, DocList.class);
                startActivity(AddDoc);
                break;

            default:
                break;
        }
    }
}