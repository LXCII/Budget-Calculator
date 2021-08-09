# Budget Calculator

An application which accepts a .csv file of bank transactions and allows the user to set categories for each transaction before proceeding to the calculator.

---
## Forms overview

### Homepage

**Features:**
1. Upload Transactions
> Prompts the user to navigate to the .csv file at button click.
2. Exit
> Closes the application at button click.

### Categorise

**Features:**
1. Display
> Displays the transactions from uploaded file segregated into a listview.
2. Instructions
> Guides the user how the 'Categoriser' works.
> 1. Check transactions to categories<br>- *Done by clicking on the checkboxes in listview.*
> 2. Select a category<br>- *Done by choosing an item in a pre-filled combobox.* <br>
> (Optional) Add a category<br>- *User can type in a custom category in a textbox and add it to combobox at button click.*
> 3. Allocate selected items to chosen category<br>- *The checked transaction items will have their Category properties set according to what was selected.*
3. Finish allocation
> Proceeds to the Calculator Form.
4. Return
> Returns to homepage.

### Calculator

**Features:**
1. Overview
> Displays the amount for total income, total expenses, and balance according to the transactions.
2. Summary
> Displays the categories in which the user has spent the most and the least, and earned the most and the least from.
3. Calculator
> Allows the user to type in their projected income and expenses and calculates the estimated overall balance (with the transactions accounted).

---
## Features to implement:
**Categorise**
- Uncheck all checked transactions in listview.
- Add permanent custom category addition to combobox.
- Separate transactions by income and expense.

**Calculator**
- Export data to file.
- Display graph of transactions.
