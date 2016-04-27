# SAP to Database
## Description
Automatic intermediate data procesor.
Gets an input file and maps the data to the custom table on MySQL.

## Requirements
- [MySql Connector](https://www.mysql.com/products/connector/)
- [FTP Limilabs](http://www.limilabs.com/ftp)

## Input Layout Transformation
```
INT|STRING|STRING|STRING|INT|INT|yyyy-MM-dd|yyyy-MM-dd|INT|STRING|STRING|STRING|
NULL OR STRING|NULL OR STRING|NULL OR STRING|INT|INT|
```

## How to use?
  1. Go to __FTP__ class and add your server address, user and password.
  2. Go to __ControladorBD__ class and add your server address, user and password.
  3. (Optional) Change directories on __Archivo__ and __FTP__ .
  4. Run

**Copyright Mundo Inmobiliario S.A**
