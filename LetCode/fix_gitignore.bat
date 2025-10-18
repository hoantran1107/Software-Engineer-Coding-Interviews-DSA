@echo off
echo ========================================
echo Fixing Git tracking for obj and bin folders
echo ========================================
echo.

cd /d "D:\GitHub\SelfStudy\Software-Engineer-Coding-Interviews-DSA"

echo Step 1: Committing .gitignore changes...
git add .gitignore
git commit -m "Update .gitignore to properly ignore obj and bin folders"
echo.

echo Step 2: Finding and removing tracked obj folders from Git index...
for /d /r %%i in (obj) do @(
    if exist "%%i" (
        echo Removing from Git: %%i
        git rm -r --cached "%%i" 2>nul
    )
)
echo.

echo Step 3: Finding and removing tracked bin folders from Git index...
for /d /r %%i in (bin) do @(
    if exist "%%i" (
        echo Removing from Git: %%i
        git rm -r --cached "%%i" 2>nul
    )
)
echo.

echo Step 4: Committing the removal of tracked obj/bin files...
git commit -m "Remove tracked obj and bin folders; rely on .gitignore"
echo.

echo Step 5: Verifying ignored status...
git status --ignored --short
echo.

echo ========================================
echo Done! The obj and bin folders are now ignored.
echo They remain on your disk but won't be tracked by Git.
echo You can now push with: git push
echo ========================================
pause

