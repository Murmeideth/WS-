package com.example.notepad;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.graphics.Typeface;
import android.os.Bundle;
import android.os.Environment;
import android.preference.PreferenceManager;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;

public class NewNote extends AppCompatActivity {

    public EditText editText;
    public String fileName = null;
    public String filePath = Environment.getExternalStorageDirectory().toString() + "/files/";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_new_note);

        editText = (EditText) findViewById(R.id.editText);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()){
            case R.id.action_clear:
                editText.setText("");
                Toast.makeText(getApplicationContext(), "Очищено", Toast.LENGTH_SHORT).show();
                return true;


            case R.id.action_open:
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.setTitle("Имя файла");
                builder.setMessage("Введите омя файла для открытия:");
                final EditText input = new EditText(this);
                builder.setView(input);
                builder.setPositiveButton("Открыть", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                    editText.setText("");
                    String value = input.getText().toString();
                    fileName = value;
                    File file = new File(filePath + fileName);
                    if (file.exists() && file.isFile())
                        {
                            editText.setText(openFile(fileName));
                        } else {
                        Toast.makeText(NewNote.this, "Файл не существует!", Toast.LENGTH_SHORT).show();
                    }
                    }
                });
                builder.show();
                return true;

            case R.id.action_save:
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.setTitle("Имя файла");
                alert.setMessage("Введите имя файла для сохранения:");
                final EditText saveName = new EditText(this);
                alert.setView(saveName);
                alert.setPositiveButton("Сохранить", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        String value = saveName.getText().toString();
                        fileName = value;
                        saveFile(fileName, editText.getText().toString());
                    }
                });
                alert.setNegativeButton("", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        Toast.makeText(NewNote.this, "Сохранение отменено", Toast.LENGTH_SHORT).show();
                    }
                });
                alert.show();
                return true;

            case R.id.action_settings:
                Intent throwing = new Intent(NewNote.this, Settings.class);
                startActivity(throwing);

                return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onResume() {
        super.onResume();
        SharedPreferences sharedPref = PreferenceManager.getDefaultSharedPreferences(this);

        float fSize = Float.parseFloat(sharedPref.getString(getString(R.string.pref_size),"14"));
        editText.setTextSize(fSize);


        String regular = sharedPref.getString(getString(R.string.pref_style), "");
        int typeFace = Typeface.NORMAL;

        if(regular.contains("Полужирный"))
            typeFace += Typeface.BOLD;

        if (regular.contains("Курсив"))
            typeFace += Typeface.ITALIC;

        if(regular.contains("Полужирный курсив"))
            typeFace += Typeface.BOLD_ITALIC;

        editText.setTypeface(null, typeFace);


        int color = Color.BLACK;
        if (sharedPref.getBoolean(getString(R.string.pref_color_red), false))
            color += Color.RED;

        if (sharedPref.getBoolean(getString(R.string.pref_color_green), false))
            color += Color.GREEN;

        if (sharedPref.getBoolean(getString(R.string.pref_color_blue), false))
            color += Color.BLUE;

        editText.setTextColor(color);
    }

    private void saveFile(String fileName, String Body)
    {
        try{
            File root = new File(this.filePath);
            if(!root.exists()){
                root.mkdirs();
            }
            File file = new File(root, fileName);
            FileWriter writer = new FileWriter(file);
            writer.append(Body);
            writer.flush();
            writer.close();
            Toast.makeText(NewNote.this, "Сохранено", Toast.LENGTH_SHORT).show();
        }
        catch(Exception e){
            e.printStackTrace();
        }
    }


    private String openFile(String fileName){
        StringBuilder text = new StringBuilder();
        try{
            File file = new File(this.filePath, fileName);
            BufferedReader br = new BufferedReader(new FileReader(file));
            String line;
            while ((line = br.readLine()) != null)
            {
                text.append(text + "\n");
            }
        }
        catch(Exception e){
            e.printStackTrace();
        }

        return text.toString();
    }


}