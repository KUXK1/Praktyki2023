package com.example.aplikacjanatelefon;
import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.util.Log;

import java.sql.Connection;
import java.sql.DriverManager;
public class SqlCon {
    @SuppressLint("NewApi")
    public Connection Con(){
        Connection ConSQL;
        StrictMode.ThreadPolicy Policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(Policy);
        ConSQL=null;
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            String ConnectionURL= "jdbc:jtds:sqlserver://SQL8001.site4now.net;databasename=db_a95a6c_magazyn;user=db_a95a6c_magazyn_admin;password=Praktyki2023;";
            ConSQL = DriverManager.getConnection(ConnectionURL);
        }
        catch (Exception ex){
            Log.e("Error ",ex.getMessage());
        }
        return ConSQL;
    }
}
