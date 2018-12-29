net stop "SQL SERVER (MOFIN)"
copy C:\Progra~1\Micros~2\MSSQL1~1.MOF\MSSQL\DATA\entorno*.* F:\Desarrollo\Monito~1\VSproj~1\mofin\Basesd~1 /y
copy C:\Progra~1\Micros~2\MSSQL1~1.MOF\MSSQL\DATA\MonitorOperaciones*.* F:\Desarrollo\Monito~1\VSproj~1\mofin\Basesd~1 /y
net start "SQL SERVER (MOFIN)"