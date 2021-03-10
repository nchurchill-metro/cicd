testOutput=$(dotnet test)
echo $testOutput;
value=$(dotnet test | grep Failed: | awk '{print $4}' | sed 's/,//g')

if [[ 0 -eq "$value" ]]
then
     echo "No Errors"
else
     echo "Errors occured"
     exit 1
fi