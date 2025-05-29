# ASP.NET MVC Web App – Price Quotation & Tip Calculator

This ASP.NET Core MVC application includes **two separate features** as part of a single assignment:

1. **Price Quotation** – Calculates discount amount and total based on subtotal and discount percent.
2. **Tip Calculator** – Calculates tips (15%, 18%, 20%) based on meal cost.

Each feature is implemented as a separate page in the application, following the MVC pattern, with validation and user-friendly styling using Bootstrap and custom CSS.

---

## 📌 Features

### 🧾 Price Quotation
- Input for subtotal and discount percentage
- Calculates and displays:
  - Discount amount
  - Total price after discount
- Validates:
  - Subtotal must be a number > 0
  - Discount % must be between 0 and 100
- Shows validation errors if input is invalid
- Clear button resets the form

### 🍽️ Tip Calculator
- Input for meal cost
- Calculates and displays:
  - 15%, 18%, and 20% tip amounts
- Validates:
  - Meal cost must be a number > 0
- Shows validation errors if input is invalid
- Clear button resets the form

---

## 🛠 Technologies Used

- ASP.NET Core MVC (.NET 8)
- C#
- Razor Views
- Bootstrap 5
- Custom CSS

---

## 🚀 How to Run

1. **Clone the repository**:

```bash
git clone https://github.com/kishankumar2607/QuotationAndTipCalculatorMVC.git
