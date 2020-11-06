package com.example.studuchet;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class Curator_activity extends AppCompatActivity implements View.OnClickListener{


    ConstraintLayout DeleteCon = (ConstraintLayout) findViewById(R.id.curator_del);
    ConstraintLayout AddCon = (ConstraintLayout) findViewById(R.id.curator_add);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_curator_activity);
    }


    //change info !!!!
    public EditText id_cur = (EditText) findViewById(R.id.input_cur_id);
    public EditText name_cur = (EditText) findViewById(R.id.input_cur_name);
    public EditText pos_cur = (EditText) findViewById(R.id.input_cur_pos);
    public EditText delete_id = (EditText) findViewById(R.id.input_cur_del_id);

    public void addCurInfo(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        int id = Integer.parseInt(id_cur.getText().toString());
        String name = name_cur.getText().toString();
        String position = pos_cur.getText().toString();
        groups groups = new groups();
        main main = new main();
        curator curator = new curator();
        dbHandler.addHandler(main, groups, curator, "curator");
        id_cur.setText("");
        name_cur.setText("");
        pos_cur.setText("");
    }

    public void RemoveCurator(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        boolean result = dbHandler.deleteHandler(Integer.parseInt(delete_id.getText().toString()), "curator");
        if (result){
            delete_id.setText("");
            Toast.makeText(getApplicationContext(),"Успешно удалено", Toast.LENGTH_SHORT).show();
        }else {
            Toast.makeText(getApplicationContext(), "Ошибка удаления", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()){
            case R.id.cur_back:
                Intent BackToMain = new Intent(this, MainActivity.class);
                startActivity(BackToMain);
                break;

            case R.id.cur_add:
                AddCon.setVisibility(View.VISIBLE);
                break;

            case R.id.cur_add_back:
                AddCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.cur_add_add:
                addCurInfo();
                AddCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.cur_delete:
                DeleteCon.setVisibility(View.VISIBLE);
                break;

            case R.id.cur_delete_back:
                DeleteCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.cur_delete_delete:
                RemoveCurator();
                DeleteCon.setVisibility(View.INVISIBLE);
                break;

            default:
                break;
        }
    }
}