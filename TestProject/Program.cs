using System;


public class TestProject
{
    public static void Main(string[] args)
    {
        CadenaConexionDB.ConexionDB conexion = new CadenaConexionDB.ConexionDB();
        conexion.OpenSqlConnection();
    }
}