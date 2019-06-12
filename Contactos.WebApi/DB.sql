-- Insert into Contacto(nombre, email, FechaNacimiento, mensaje) values
-- ('George','slim182@gmail.com','19860203','This is me'),
-- ('Marina','marina@gmail.com','19860616','This is not me'),
-- ('Twito','twito2014@gmail.com','20151231','This is me');

select * from [User];



-- Get a list of tables and views in the current database
SELECT table_catalog [database], table_schema [schema], table_name name, table_type type
FROM INFORMATION_SCHEMA.TABLES
GO

select * From Contacto;


delete from contacto where id>5;

-- Add migration
-- dotnet ef migrations add UsersTable

-- Apply migration
-- dotnet ef database update

-- Rollback to previous version
-- dotnet ef database update InitialDB

