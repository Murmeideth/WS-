package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class EmploList extends AppCompatActivity implements View.OnClickListener {

    TextView Field = (TextView)findViewById(R.id.Emplo_view);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_emplo_list);
    }

    public void loadInfo(View view) {
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        Field.setText(dbHandler.loadHandler());
    }

    @SuppressLint("NonConstantResourceId")
    @Override
    public void onClick(View view){
        switch(view.getId()){
            case R.id.back_emp:
                Intent BEmp = new Intent(this, MainActivity.class);
                startActivity(BEmp);
                break;

            case R.id.add_emp:
                Intent AddEmp = new Intent(this, Emp_add.class);
                startActivity(AddEmp);
                break;

            case R.id.del_emp:
                Intent DelEmp = new Intent(this, Emp_delete.class);
                startActivity(DelEmp);
                break;

            default:
                break;
        }
    }
}