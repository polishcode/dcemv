@ECHO OFF

rem /bin & /obj dirs are automagically recreated by Visual Studio
rem but the command below will remove actual binaries (build products)

for /r /d %%A in (bin,obj,arm,x86,x64,.vs) do if exist "%%A" ( 
	echo removing "%%A"
	RMDIR /S /Q "%%A"
)

@ECHO ON