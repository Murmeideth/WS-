package com.example.studuchet;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class Groups_activity extends AppCompatActivity implements View.OnClickListener{

    ConstraintLayout DeleteCon = (ConstraintLayout) findViewById(R.id.group_del_cont);
    ConstraintLayout AddCon = (ConstraintLayout) findViewById(R.id.group_add_cont);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_groups_activity);
    }

    public EditText id_group = (EditText) findViewById(R.id.input_group_id);
    public EditText code_group = (EditText) findViewById(R.id.input_group_code);
    public EditText desc_group = (EditText) findViewById(R.id.input_group_desc);
    public EditText delete_id = (EditText) findViewById(R.id.input_group_delete);

    public void addGroupInto(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        int id = Integer.parseInt(id_group.getText().toString());
        String code = code_group.getText().toString();
        String desc = desc_group.getText().toString();
        groups groups = new groups(id, code, desc);
        main main = new main();
        curator curator = new curator();
        dbHandler.addHandler(main, groups, curator, "groups");
        id_group.setText("");
        code_group.setText("");
        desc_group.setText("");
    }

    public void RemoveGroup(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        boolean result = dbHandler.deleteHandler(Integer.parseInt(delete_id.getText().toString()), "groups");
        if (result){
            delete_id.setText("");
            Toast.makeText(getApplicationContext(),"Успешно удалено", Toast.LENGTH_SHORT).show();
        }else {
            Toast.makeText(getApplicationContext(), "Ошибка удаления", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onClick(View view){
        switch(view.getId()){
            case R.id.group_back:
                Intent BackToMain = new Intent(this, MainActivity.class);
                startActivity(BackToMain);
                break;

            case R.id.group_add:
                AddCon.setVisibility(View.VISIBLE);
                break;

            case R.id.group_add_back:
                AddCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.group_add_add:
                addGroupInto();
                AddCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.group_delete:
                DeleteCon.setVisibility(View.VISIBLE);
                break;

            case R.id.group_delete_back:
                DeleteCon.setVisibility(View.INVISIBLE);
                break;

            case R.id.groupd_delete_delete:
                RemoveGroup();
                DeleteCon.setVisibility(View.INVISIBLE);
                break;

            default:
                break;
        }
    }
}