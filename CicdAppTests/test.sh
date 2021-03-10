value=$(cat /home/vsts/work/_temp/*.trx | grep "<Counters" | awk '{print $5}' | sed 's/failed=//g' | sed 's/"//g')

if [[ 0 -eq "$value" ]]
then
     echo "No Errors"
else
     echo "Errors occured"
     exit 1
fi