# Kids Shop

## Steps to run program

### Run the Product Service API
1. Open the **Microsoft SQL Server Management Studio**
2. Go to **File88** -> **Connect Object Explorer** and copy the Server name and press **Connect**
3. Then Open the Product Service .sln file in **Visual Studio**
4. Open the DatabaseContext.cs class from Database folder and paste the Server name from Step 2 and paste it in the data source. The following code snippet
demonstrated where to paste the code
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = LAPTOP-V0UGO61O\SQLEXPRESS; initial catalog = Products; persist security info = True; Integrated Security = SSPI;");
        }
                                                        ^^^^^^^^^^^^^^^^^^^^^^^^
                                                        ||||||||||||||||||||||||
                                                         
```
5. The arrow is where you will paste the code
