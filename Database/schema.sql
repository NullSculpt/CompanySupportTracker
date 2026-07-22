-- Create database
CREATE DATABASE CompanySupport;
GO

USE CompanySupport;
GO

-- Company support records
CREATE TABLE tbl_Company (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    companyname NVARCHAR(1000)  NOT NULL,
    explanation NVARCHAR(1000) NOT NULL,
    result      BIT           NULL,
    [date]      DATE          NULL,
    username    NVARCHAR(50)  NULL
);
GO

-- Login table
CREATE TABLE tbl_login (
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL
);
GO

-- Default login
INSERT INTO tbl_login (username, password)
VALUES ('admin', '1234');
GO
