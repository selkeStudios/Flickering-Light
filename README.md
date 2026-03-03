Given that this repository has associated files with incredibly long filepath names, run the following command below 
in either a Command Prompt or Git Bash if you run into a "Filename too long" error when trying to clone this repository.

git config --global core.longpaths true

This command will enable long file path names across your machine, allowing long paths for every repository you EVER clone
and ignoring Git's filename 4096 character limit.
