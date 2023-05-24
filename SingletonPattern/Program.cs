using SingletonPattern;

var connection = DatabaseConnectionManager.GetDatabaseConnectionManager();
connection.DisplayStatus();