#! /bin/sh

if [ -z "$1" ] 
then
    echo "commit message is required..."
    exit
fi

git add .
git commit -m "$1"
git push origin master

echo "done"