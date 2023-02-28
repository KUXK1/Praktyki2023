package com.example.aplikacjamobilna;
import java.sql.SQLException;
import  java.sql.Statement;
import androidx.activity.result.ActivityResultLauncher;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.motion.widget.Debug;

import android.content.DialogInterface;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import com.journeyapps.barcodescanner.ScanContract;
import com.journeyapps.barcodescanner.ScanOptions;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

public class MainActivity extends AppCompatActivity {
    Button Dodaj;
    Connection laczenie;
    EditText ile;
    Button Usun;
    String komponent;
    String[] arr=null;
    String x;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Dodaj=findViewById(R.id.Dodaj);
        Dodaj.setOnClickListener(view -> {
                ile=(EditText)findViewById(R.id.Ile);
                x=ile.getText().toString();
                Skanuj();
                Dodaj();

        });
        Usun=findViewById(R.id.Usun);
        Usun.setOnClickListener(view -> {
            Usun();
        });

    }

    private void Usun() {
        Skanuj();
        try {
            BazaDanych bazaDanych = new BazaDanych();
            laczenie = bazaDanych.SQL();
            String querySel = "SELECT ilosc FROM komponenty WHERE nazwa = '"+arr[1]+"';";
            String queryUp = "Update komponenty set ilosc = ilosc -"+x+" where nazwa ='"+arr[1]+"';";
            if(laczenie!=null){
                Statement st =laczenie.createStatement();
                ResultSet rs = st.executeQuery(querySel);
                if (rs.next()){
                    int ilosc = rs.getInt("ilosc");
                    if (ilosc>0){
                        st.executeQuery(queryUp);
                    }
                }
            }else{
                System.out.println ("blad w laczu");
            }
        }
        catch (Exception ex){
            System.out.println (ex);
        }

    }

    public void  Dodaj() {
        Statement st= null;
        try {
            BazaDanych bazaDanych = new BazaDanych();

            laczenie = bazaDanych.SQL();
            if (laczenie != null) {
                String queryIn = "INSERT INTO komponenty (ID,typ,nazwa,Ilosc) VALUES (NULL,'"+arr[0]+"' ,'"+arr[1]+"','"+x+"');";
                String querySel = "SELECT * FROM komponenty WHERE nazwa = '"+arr[1]+"';";
                String queryUp= "Update komponenty set ilosc = ilosc + "+x+" where nazwa ='"+arr[1]+"';";
                st = laczenie.createStatement();
                ResultSet resultSet = st.executeQuery(querySel);
                if (resultSet.next()) {
                    st.executeUpdate(queryUp);
                } else {
                    st.executeQuery(queryIn);
                }
                resultSet.close();
                st.close();
                laczenie.close();

            } else {
                st.close();
                laczenie.close();
                System.out.println ("blad w kodzie z encja !!!");
            }
        }
        catch (Exception ex){
            System.out.println (ex);
        }
    }
    private void Skanuj() {
        ScanOptions Ustawienia = new ScanOptions().setPrompt("Test").setBeepEnabled(true).setOrientationLocked(true).setCaptureActivity(Permisje.class);

        Scaner.launch(Ustawienia);

    }
    ActivityResultLauncher<ScanOptions> Scaner = registerForActivityResult( new ScanContract(),result -> {
        if(result.getContents()!=null){
            System.out.println (result.getContents());
            komponent=result.getContents();
            arr = komponent.split(" ");

        }
    });
}