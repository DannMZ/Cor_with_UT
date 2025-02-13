# Project: Chain of Responsibility Text Filter

## Description
This C# WinForms application implements the **Chain of Responsibility** design pattern to filter and process user input text. The program consists of multiple handlers that process text input sequentially.

## Features
- Implements the Chain of Responsibility pattern for filtering text.
- Uses three filters:
  1. **Is_this_question_normal** – Initial filter to check the nature of the input.
  2. **FromAtoM** – Processes words starting from A to M.
  3. **FromNtoZ** – Processes words starting from N to Z.
- Provides a graphical user interface (GUI) for input handling.
- Displays processed output via a message box.

## Usage
1. **Run the application** in Visual Studio.
2. **Enter text** into the input field.
3. Click the **Submit (button1)** to process the text.
4. The processed result is displayed in a **message box**.

## Code Structure
- **Form1.cs** – Main application logic and GUI event handlers.
- **Handler_ (Abstract Class)** – Base class for handling text.
- **Is_this_question_normal.cs** – Initial filter in the chain.
- **FromAtoM.cs** – Handles text that falls within the A-M range.
- **FromNtoZ.cs** – Handles text that falls within the N-Z range.

## Example Output
```
User input: "Hello"
Output: Processed by FromAtoM
```

## Notes
- The first filter (`Is_this_question_normal`) checks whether the text is valid.
- If a handler cannot process the request, it passes it to the next one in the chain.
- TextBox resets when the mouse enters the input field.

## License
This project is open-source. Feel free to modify and use it as needed.

## Author
Mazarin