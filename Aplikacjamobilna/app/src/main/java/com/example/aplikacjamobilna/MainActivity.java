package com.example.aplikacjamobilna;
import java.sql.SQLException;
import  java.sql.Statement;
import androidx.activity.result.ActivityResultLauncher;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.motion.widget.Debug;

import android.content.DialogInterface;
import android.os.Bundle;
import android.widget.Button;

import com.journeyapps.barcodescanner.ScanContract;
import com.journeyapps.barcodescanner.ScanOptions;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class MainActivity extends AppCompatActivity {
    Button Dodaj;
    Connection laczenie;
    Button Usun;
    String komponent;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Dodaj=findViewById(R.id.Dodaj);
        Dodaj.setOnClickListener(view -> {

                Dodaj();

        });
        Usun=findViewById(R.id.Usun);
        Usun.setOnClickListener(view -> {
            Usun();
        });

    }

    private void Usun() {
        Skanuj();
    }

    private void  Dodaj() {
        //Skanuj();
        try {
            BazaDanych bazaDanych = new BazaDanych();
            laczenie = bazaDanych.SQL();
            if (laczenie != null) {
                String query = "INSERT INTO kondesator (`Id', `Nazwa`, `Ilość`) VALUES (NULL,'test', '20')";
                Statement stmt = laczenie.createStatement();
                stmt.executeQuery(query);
            }
        }
        catch (Exception ex){
        }
    }
    private void Skanuj() {
        ScanOptions Ustawienia = new ScanOptions();
        Ustawienia.setPrompt("Test");
        Ustawienia.setBeepEnabled(true);
        Ustawienia.setOrientationLocked(true);
        Ustawienia.setCaptureActivity(Permisje.class);
        Scaner.launch(Ustawienia);

    }
    ActivityResultLauncher<ScanOptions> Scaner = registerForActivityResult( new ScanContract(),result -> {
        if(result.getContents()!=null){
            komponent=result.getContents();
        }
    });
}