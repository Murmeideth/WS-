package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class DocList extends AppCompatActivity implements View.OnClickListener {

    TextView Field = (TextView)findViewById(R.id.Doc_view);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doc_list);
    }

    public void loadInfo(View view) {
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        Field.setText(dbHandler.loadHandler());
    }

    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.back_doc:
                Intent BDoc = new Intent(this, MainActivity.class);
                startActivity(BDoc);
                break;

            case R.id.add_doc:
                Intent AddDoc = new Intent(this, Doc_add.class);
                startActivity(AddDoc);
                break;

            case R.id.del_doc:
                Intent DelDoc = new Intent(this, Doc_delete.class);
                startActivity(DelDoc);
                break;

            default:
                break;
        }
    }
}