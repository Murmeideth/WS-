package com.example.holidays;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class Emp_add extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_emp_add);
    }

    public EditText id_em = (EditText) findViewById(R.id.ID_emp_add);
    public EditText name_em = (EditText) findViewById(R.id.Name_emp_add);
    public EditText desc_em = (EditText) findViewById(R.id.Disc_emp_add);
    public EditText pos_em = (EditText) findViewById(R.id.Position_emp_add);
    public void addInfoEmp(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        int id = Integer.parseInt(id_em.getText().toString());
        String name = name_em.getText().toString();
        String desc = desc_em.getText().toString();
        String pos = pos_em.getText().toString();
        employers employers = new employers(id, name, desc, pos);
        dbHandler.addEmp(employers);
        id_em.setText("");
        name_em.setText("");
        desc_em.setText("");
        pos_em.setText("");
    }

    @Override
    public void onClick(View view){
        switch (view.getId()){

            case R.id.Back_emp_add:
                Intent BEmp = new Intent(this, EmploList.class);
                startActivity(BEmp);
                break;

            case R.id.Add_emp_add:
                addInfoEmp();
                Intent AddEmp = new Intent(this, EmploList.class);
                startActivity(AddEmp);
                break;

            default:
                break;
        }
    }
}