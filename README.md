
# DirectoryTree Utility

## Description
DirectoryTree is a C# console application that scans a specified directory and builds a tree-like representation of its structure. It can also read and respect rules specified in a `.gitignore` file.

## Usage

### No Arguments
If no arguments are provided, the utility will scan the directory from where it's executed.

```
DirectoryTree.exe
```

### One Argument
With one argument, the utility will scan the specified directory and look for the `.gitignore` file in its own directory (where the utility is executed).

```
DirectoryTree.exe <path_to_scan>
```

### Two Arguments
If two arguments are provided, the first is the path to scan, and the second is the path to the `.gitignore` file.

```
DirectoryTree.exe <path_to_scan> <path_to_gitignore>
```

## Note
This utility supports basic `.gitignore` patterns like `*.log` or specific filenames and directory names but does not fully implement the complete range of `.gitignore` pattern rules.
