package com.example.aplikacjanatelefon;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import java.sql.Connection;
import java.sql.Statement;

public class MainActivity extends AppCompatActivity {
    Button Add;
    Button Remove;
    Button Scan;
    EditText Q;
    EditText T;
    EditText Id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Q= findViewById(R.id.quantity);
        T=findViewById(R.id.Type);
        Id = findViewById(R.id.IdNum);
        Scan = findViewById(R.id.Scan);
        Add = findViewById(R.id.Add);
        Remove = findViewById(R.id.Remove);
        Scan.setOnClickListener(view -> {
                scan();
        });
        Add.setOnClickListener(view -> {
                Add();
        });
        Remove.setOnClickListener(view -> {
            Remove();
        });

    }

    private void Add() {
        try {
            SqlCon sqlCon = new SqlCon();
            Connection Login = sqlCon.Con();
            String x = Q.getText().toString();
            String y = Id.getText().toString();
            String z = T.getText().toString();
            String queryUp = "Update " + z + " set Quantity = Quantity +" + x + " where Component_number ='" + y + "';";
            if (Login != null) {
                Statement st = Login.createStatement();
                st.executeQuery(queryUp);

            }
            Login.close();
        }catch (Exception ex){
            System.out.println (ex);
        }
        clean();
    }
    private void Remove() {
        try {
            SqlCon sqlCon = new SqlCon();
            Connection Login = sqlCon.Con();
            String x = Q.getText().toString();
            String y = Id.getText().toString();
            String z = T.getText().toString();
            String queryUp = "Update " + z + " set Quantity = Quantity -" + x + " where Component_number ='" + y + "';";
            if (Login != null) {
                Statement st = Login.createStatement();
                st.executeQuery(queryUp);

            }
            Login.close();
        }catch (Exception ex){
            System.out.println (ex);
        }
        clean();
    }
    private  void clean(){
        T.setText(null);
        Id.setText(null);
        Q.setText(null);
    }
    public void scan(){
        IntentIntegrator intentIntegrator = new IntentIntegrator(
                MainActivity.this
        );
        intentIntegrator.setBeepEnabled(true);
        intentIntegrator.setOrientationLocked(true);
        intentIntegrator.setCaptureActivity(Capture.class);
        intentIntegrator.initiateScan();
    }
    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        IntentResult intentResult = IntentIntegrator.parseActivityResult(
                requestCode,resultCode,data
        );
        if (intentResult.getContents() != null){
            String Result = intentResult.getContents();
            String[] ResultTable = Result.split(" ");
            T.setText(ResultTable[0]);
            Id.setText(ResultTable[1]);
        }
    }
}