# Deltarune Debug Mode Script

This script enables debug mode permanently in Deltarune Chapter 3.

## Requirements
- UndertaleModTool

## Instructions
1. Open UndertaleModTool
2. Load the `data.win` file from the `(CHAPTER)_windows` folder
3. Go to **Scripts** → **Run other script**
4. Select and run the debug script from this repository

## What it does
- Changes `global.debug = 0` to `global.debug = 1` in the game's initialization code
- Enables debug mode permanently when the game starts

## Note
Make sure to backup your original `data.win` file before applying any modifications.
