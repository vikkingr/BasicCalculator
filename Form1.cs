using System;
using System.CodeDom;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
	/// <summary>
	/// A basic calculator!
	/// </summary>
	public partial class Form1 : Form
	{

		// This is the constructor se let's use #region
		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region Clearing Methods

		/// <summary>
		/// Clears the user input text.
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void CEButton_Click(object sender, EventArgs e)
		{
			// Clears the text from the user input text box
			this.UserInputText.Text = string.Empty;

			// Focus the user input text
			FocusInputText();
		}

		/// <summary>
		/// Deletes the first character in front of the cursor
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void DelButton_Click(object sender, EventArgs e)
		{
			
			// Delete the value after the selected position
			DeleteTextValue();

			// Focus the user input text
			FocusInputText();

		}

		#endregion

		#region Operator Functions

		/// <summary>
		/// Adds the divide character to the current selected text position
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void DivideButton_Click(object sender, EventArgs e)
		{
			
			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("/");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds the times character the current text position
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void TimesButton_Click(object sender, EventArgs e)
		{

			InsertTextValue("*");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Add the minus character to the current text position
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void MinusButton_Click(object sender, EventArgs e)
		{

			InsertTextValue("-");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Add the plus char to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void PlusButton_Click(object sender, EventArgs e)
		{

			InsertTextValue("+");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Calculates the given equation in the user input text box
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void EqualsButton_Click(object sender, EventArgs e)
		{
			
			// calculate the equation
			CalculateEquation();

			// Focus the user input text
			FocusInputText();

		}

		#endregion

		#region Number Methods

		/// <summary>
		/// Add the . char to the current text position
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void DotButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue(".");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a "0" the user input text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void ZeroButton_Click(object sender, EventArgs e)
		{

			// Insert a zero to where the cursor is selected in the user input text
			InsertTextValue("0");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 1 to the user input text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void OneButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("1");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 2 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void TwoButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("2");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 3 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void ThreeButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("3");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 4 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void FourButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("4");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 5 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void FiveButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("5");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 6 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void SixButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("6");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 7 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void SevenButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("7");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 8 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void EightButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("8");

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Adds a 9 to the text
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">The event arguments</param>
		private void NineButton_Click(object sender, EventArgs e)
		{

			// Insert the value to the user input text box at the currently selected position
			InsertTextValue("9");

			// Focus the user input text
			FocusInputText();

		}

		#endregion

		/// <summary>
		/// Calculates the given equation to the user label
		/// </summary>
		private void CalculateEquation()
		{

			this.CalculationResultText.Text = ParseOperation();

			// Focus the user input text
			FocusInputText();

		}

		/// <summary>
		/// Parses the users equation and calculates the result
		/// </summary>
		/// <returns></returns>
		private string ParseOperation()
		{
			
			try
			{
				
				// Get the user's equation input
				var input = this.UserInputText.Text;

				// Remove all spaces
				input = input.Replace(" ", "");

				// Create new top level operation
				var operation = new Operation();
				var leftSide = true;

				// Loop through each character of the input from left to right
				for (int i = 0; i < input.Length; i++)
				{
					
					// TODO: handle order priority

					// Check if a char is a number
					if ("0123456789.".Any(c => input[i] == c))
					{
						
						if (leftSide)
						{ 
							
							operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);

						}
						else
						{

							operation.RightSide = AddNumberPart(operation.RightSide, input[i]);

						}

					}
					// Check if it is an operator, if so, set the operator type.
					else if ("+-*/".Any(c => input[i] == c))
					{

						// If we are on the right side, we don't need to calc our current operation
						// And set the result to the left side of the next operation
						if (!leftSide)
						{

							// Get the operator type
							var operatorType = GetOperationType(input[i]);

							// Check for a rigjt side number
							if (operation.RightSide.Length == 0)
							{

								// Check the operator is not minus (as they could be creating a negative number)
								if (operatorType != OperationType.Minus)
								{

									throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without a right side number.");

								}

								// If we are hre, operator type is a minus, and there is no left number currently, so add the minus to the number
								operation.RightSide += input[i];

							}
							else 
							{
								
								// Calculate previous equation and set to the left side
								operation.LeftSide = CalculateOperation(operation);

								// Set new operator
								operation.OperationType = operatorType;

								// Clear the previous right number
								operation.RightSide = string.Empty;

							}

						}
						else
						{
							
							// Get the operator type
							var operatorType = GetOperationType(input[i]);

							// Check for a left side number
							if (operation.LeftSide.Length == 0)
							{
								
								// Check the operator is not minus (as they could be creating a negative number)
								if (operatorType != OperationType.Minus) 
								{
									
									throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without a left side number.");

								}

								// If we are hre, operator type is a minus, and there is no left number currently, so add the minus to the number
								operation.LeftSide += input[i];

							}
							else 
							{

								// If we have a left number and now an operator, so we want to move the right side

								// Set the operation type
								operation.OperationType = operatorType;

								// Move to the right side
								leftSide = false;

							}

						}

					}

				}

				// If we are done parsing, and there are no exceptions.
				// Calculate the current operation
				return CalculateOperation(operation);

			}
			catch (Exception ex)
			{
				
				return $"Invalid equation. { ex.Message }";

			}

		}

		#region Private Helpers

		/// <summary>
		/// Focuses the user input text
		/// </summary>
		private void FocusInputText() 
		{ 
			this.UserInputText.Focus();
		}

		/// <summary>
		/// Inserts the given text to the user text box
		/// </summary>
		/// <param name="value">Value to insert</param>
		private void InsertTextValue(string value) {

			// Remember the selection start
			var selectionStart = this.UserInputText.SelectionStart;

			// set new text
			this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

			// restore selection start
			this.UserInputText.SelectionStart = selectionStart + value.Length;

			// set selection length to 0
			this.UserInputText.SelectionLength = 0;

		}

		/// <summary>
		/// Deletes the character to the right of the start of user text box
		/// </summary>
		private void DeleteTextValue()
		{
			
			// If we don't have a value to delete, return
			if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
				return;

			// Remember the selection start
			var selectionStart = this.UserInputText.SelectionStart;

			// Delete the character to the right of the selection
			this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

			// restore selection start
			this.UserInputText.SelectionStart = selectionStart;

			// set selection length to 0
			this.UserInputText.SelectionLength = 0;

		}

		/// <summary>
		/// Add new char to current number, check for valid characters
		/// </summary>
		/// <param name="currentNumber">Current number string</param>
		/// <param name="newCharacter">New char to append to string</param>
		/// <returns></returns>
		private string AddNumberPart(string currentNumber, char newCharacter)
		{
		
			// Check for a . in number
			if (newCharacter == '.' && currentNumber.Contains('.'))
				throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added.");

			return currentNumber + newCharacter;

		}

		/// <summary>
		/// Accepts a char and returns the known <see cref="OperationType"/>
		/// </summary>
		/// <param name="character">The operator character to pass</param>
		/// <returns>The known <see cref="OperationType"/></returns>
		private OperationType GetOperationType(char character)
		{
			
			switch (character)
			{

				case '+':
					return OperationType.Add;
				case '-':
					return OperationType.Minus;
				case '/':
					return OperationType.Divide;
				case '*':
					return OperationType.Multiply;
				default:
					throw new InvalidOperationException($"Unknown operator type: { character }.");

			}

		}

		/// <summary>
		/// Calculates an <see cref="Operation"/> and return the result
		/// </summary>
		/// <param name="operation">The operation to calculate</param>
		/// <returns></returns>
		private string CalculateOperation(Operation operation)
		{
			
			// Store the number values of the string representations
			decimal left = 0;
			decimal right = 0;

			// Check if we have a valid left side number
			if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
			{

				throw new InvalidOperationException($"Left side of the operation was not a number {operation.LeftSide}.");

			}

			// Check if we have a valid right side number
			if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
			{

				throw new InvalidOperationException($"Right side of the operation was not a number {operation.RightSide}.");

			}

			try
			{
				
				switch (operation.OperationType)
				{

					case OperationType.Add:
						return (left + right).ToString();
					case OperationType.Minus:
						return (left - right).ToString();
					case OperationType.Divide:
						return (left / right).ToString();
					case OperationType.Multiply:
						return (left * right).ToString();
					default:
						throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.OperationType }");

				}

			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Failed to calculate operation { operation.LeftSide } { operation.OperationType } { operation.RightSide }. { ex.Message }");
			}

			return string.Empty;

		}

		#endregion

	}

}
