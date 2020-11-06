package com.example.studuchet;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    TextView Field = (TextView) findViewById(R.id.mainField);
    ConstraintLayout Add_stud = (ConstraintLayout) findViewById(R.id.add_layout);
    @SuppressLint("WrongViewCast")
    ConstraintLayout Delete_stud = (ConstraintLayout) findViewById(R.id.stud_del);

    EditText delete_ID = (EditText) findViewById(R.id.input_delete_stud_id);
    EditText id_stud = (EditText) findViewById(R.id.input_id_stud);
    EditText name_stud = (EditText) findViewById(R.id.input_name_stud);
    EditText group_stud = (EditText) findViewById(R.id.input_group_stud);
    EditText curator_stud = (EditText) findViewById(R.id.input_curator_student);


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void Remove(){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        boolean result = dbHandler.deleteHandler(Integer.parseInt(delete_ID.getText().toString()), "main");
        if (result){
            delete_ID.setText("");
            Toast.makeText(getApplicationContext(),"Успешно удалено", Toast.LENGTH_SHORT).show();
        }else {
            Toast.makeText(getApplicationContext(), "Ошибка удаления", Toast.LENGTH_SHORT).show();
        }
    }

    public void addStud_info(){
        MyDBHandler dbHandler = new MyDBHandler(this, null,null,1);
        int id = Integer.parseInt(id_stud.getText().toString());
        String name = name_stud.getText().toString();
        String group = group_stud.getText().toString();
        String curator = curator_stud.getText().toString();

        main main = new main(id, name, group, curator);
        groups groups = new groups();
        curator curatore = new curator();
        dbHandler.addHandler(main, groups, curatore, "main");
        id_stud.setText("");
        name_stud.setText("");
        group_stud.setText("");
        curator_stud.setText("");
    }

    @Override
    public void onClick(View view){
        switch (view.getId()){
            case R.id.add_stud:
                Add_stud.setVisibility(View.VISIBLE);
                break;

            case R.id.add_button_back:
                Add_stud.setVisibility(View.INVISIBLE);
                break;

            case R.id.add_stud_button:
                addStud_info();
                Add_stud.setVisibility(View.INVISIBLE);
                break;

            case R.id.stud_del:
                Delete_stud.setVisibility(View.VISIBLE);
                break;

            case R.id.delete_back_button:
                Delete_stud.setVisibility(View.INVISIBLE);
                break;

            case R.id.delete_stud_button:
                Remove();
                Delete_stud.setVisibility(View.INVISIBLE);
                break;

            case R.id.goto_cur:
                Intent Curator = new Intent(this, Curator_activity.class);
                startActivity(Curator);
                break;

            case R.id.goto_groups:
                Intent Groups = new Intent(this, Groups_activity.class);
                startActivity(Groups);
                break;

            default:
                break;
        }
    }


    public void loadInfo(View view){
        MyDBHandler dbHandler = new MyDBHandler(this, null, null, 1);
        Field.setText(dbHandler.loadHandler("main"));
    }
}