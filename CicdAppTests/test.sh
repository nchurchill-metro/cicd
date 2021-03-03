
value=$(dotnet test | grep Failed: | awk '{print $4}' | sed 's/,//g')

if [[ 0 -eq "$value" ]]
then
     echo "No Errors"
fi


