package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class Doc_delete extends AppCompatActivity implements View.OnClickListener{

    public TextView del = (TextView)findViewById(R.id.Deleted_id_doc);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doc_delete);
    }

    public void Remove_event(){
        MyDBHandler dbHandler = new MyDBHandler(this, null,null, 1);
        boolean result = dbHandler.deleteHandler(Integer.parseInt(del.getText().toString()));
        if (result) {
            del.setText("");
            Toast.makeText(getApplicationContext(), "Успешно удалено.", Toast.LENGTH_SHORT).show();
        }else{
            Toast.makeText(getApplicationContext(), "Ошибка удаления", Toast.LENGTH_SHORT).show();
        }

    }

    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.Delete_back_doc:
                Intent DelB = new Intent(this, DocList.class);
                startActivity(DelB);
                break;

            case R.id.delete_done_doc:
                Remove_event();
                Intent DoneD = new Intent(this, DocList.class);
                startActivity(DoneD);
                break;

            default:
                break;
        }
    }
}