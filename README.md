# Es_AppleStore Edoardo Borgogno
Apple store management software

## What can you do?
This project allows you to manage a list of customers, products, categories and orders, there are also charts with useful statistics to understand the sales trend.

## Project Organization

##### used packages:
  - LiveCharts.Wpf.0.9.7
  - LiveCharts.WinForms.0.9.7.1
  - LiveCharts.0.9.7

##### Directory Tree
  ```
  ├───Screens
  │   ├───Add Screens
  │   │   │   AddCategories.cs
  │   │   │   AddCategories.Designer.cs
  │   │   │   AddCategories.resx
  │   │   │   AddCustomers.cs
  │   │   │   AddCustomers.Designer.cs
  │   │   │   AddCustomers.resx
  │   │   │   AddOrder.cs
  │   │   │   AddOrder.Designer.cs
  │   │   │   AddOrder.resx
  │   │   │   AddProduct.cs
  │   │   │   AddProduct.Designer.cs
  │   │   │   AddProduct.resx
  │   │   │
  │   │   └───Add Screens Component
  │   │           ProductOrder.cs
  │   │           ProductOrder.Designer.cs
  │   │           ProductOrder.resx
  │   │
  │   ├───Dashboard
  │   │   │   Dashboard.cs
  │   │   │   Dashboard.Designer.cs
  │   │   │   Dashboard.resx
  │   │   │
  │   │   └───Dashboard Components
  │   │           ChartYear.cs
  │   │           ChartYear.Designer.cs
  │   │           ChartYear.resx
  │   │           TopItem.cs
  │   │           TopItem.Designer.cs
  │   │           TopItem.resx
  │   │
  │   ├───Edit Screens
  │   │       EditCategories.cs
  │   │       EditCategories.Designer.cs
  │   │       EditCategories.resx
  │   │       EditCustomer.cs
  │   │       EditCustomer.Designer.cs
  │   │       EditCustomer.resx
  │   │       EditProduct.cs
  │   │       EditProduct.Designer.cs
  │   │       EditProduct.resx
  │   │
  │   ├───Home
  │   │   │   Home.cs
  │   │   │   Home.Designer.cs
  │   │   │   Home.resx
  │   │   │
  │   │   └───Home Components
  │   │           analyticsMonth.cs
  │   │           analyticsMonth.Designer.cs
  │   │           analyticsMonth.resx
  │   │           ChartOrders.cs
  │   │           ChartOrders.Designer.cs
  │   │           ChartOrders.resx
  │   │
  │   ├───Orders
  │   │   │   Orders.cs
  │   │   │   Orders.Designer.cs
  │   │   │   Orders.resx
  │   │   │
  │   │   └───Orders Components
  │   │           bestProduct.cs
  │   │           bestProduct.Designer.cs
  │   │           bestProduct.resx
  │   │           ChartOrdersForMonth.cs
  │   │           ChartOrdersForMonth.Designer.cs
  │   │           ChartOrdersForMonth.resx
  │   │
  │   ├───Registry
  │   │       RegistryScreen.cs
  │   │       RegistryScreen.Designer.cs
  │   │       RegistryScreen.resx
  │   │
  │   └───View Order
  │       │   ViewOrder.cs
  │       │   ViewOrder.Designer.cs
  │       │   ViewOrder.resx
  │       │
  │       └───View Order Component
  │               OrderDetail.cs
  │               OrderDetail.Designer.cs
  │               OrderDetail.resx
  │
  └───Services
      └───Database
              adoNetSQL.cs
  ```
  
 ## Usage
 
 On the left bar you can select the screen, there are four different screens: 'Home', 'Personal data', 'Sales', 'Dashboard'.
 
