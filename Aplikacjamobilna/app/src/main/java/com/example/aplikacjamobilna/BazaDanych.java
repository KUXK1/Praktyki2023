package com.example.aplikacjamobilna;
import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.util.Log;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;


public class BazaDanych {
    Connection polaczenie;
    @SuppressLint("NewApi")
    public Connection SQL(){
        String ip="192.168.0.27";
        String bazadanych="magazyn";
        String uzytkownik="KUXK";
        String haslo="123";
        String port="3306";
        StrictMode.ThreadPolicy zasady = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(zasady);
        Connection laczenie=null;
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            String URL= "jdbc:jtds:sqlserver://"+ ip + ":"+ port + ";"+"databasename="+ bazadanych + ";User="+ uzytkownik +";password="+haslo+";";
            polaczenie = DriverManager.getConnection(URL);
        }
        catch (Exception ex){
            Log.e("Error ",ex.getMessage());
        }

        return laczenie;
    }
}
