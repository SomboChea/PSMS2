git add .

current_date_time=`date "+%Y-%m-%d %Hh:%Mm:%Ss"`

read -p "Enter message to commit: " msg

message=$msg" on "$current_date_time

git commit -m $message

git push -u origin master

read -p "Press enter to continue..."