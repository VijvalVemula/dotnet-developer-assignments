--Q1
--With sub-query
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City IN (
    SELECT DISTINCT e.City
    FROM Employees e 
    WHERE e.EmployeeID IS NOT NULL
);

--With JOIN
SELECT DISTINCT e.City
FROM Employees e
INNER JOIN Customers c ON e.City = c.City

--Q2
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City NOT IN (
    SELECT DISTINCT e.City
    FROM Employees e 
    WHERE e.EmployeeID IS NOT NULL
);

--With JOIN
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL
ORDER BY c.City;

--Q3
--With correlated sub-query
SELECT p.ProductName, (
    SELECT SUM(od.Quantity)
    FROM [Order Details] od
    WHERE od.ProductID = p.ProductID
) AS TotalOrderQuantity
FROM Products p
ORDER BY TotalOrderQuantity DESC;

--With Join
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrderQuantity
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalOrderQuantity DESC;

--Q4
SELECT c.City AS CustomerCity, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;

--Q5
SELECT c.City AS CustomerCity, COUNT(c.CustomerID) AS NumberOfCustomers
FROM Customers c
GROUP BY City
HAVING COUNT(CustomerID) >= 2;

--Q6
SELECT c.City AS CustomerCity, COUNT(DISTINCT od.ProductID) AS DistinctProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;


--Q7
SELECT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity
ORDER BY c.CustomerID;

--Q8
SELECT TOP 5  p.ProductName, AVG(od.UnitPrice) AS AveragePrice, c.City AS TopCustomerCity, SUM(od.Quantity) AS PopularityByQuantityOrdered
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductID, p.ProductName, c.City
ORDER BY SUM(od.Quantity) DESC;

--Q9
-- Sub-query
SELECT DISTINCT e.City AS EmployeeCity
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT c.City
    FROM Customers c
    INNER JOIN Orders o ON c.CustomerID = o.CustomerID
);

--JOIN
SELECT DISTINCT e.City AS EmployeeCity
FROM Employees e
LEFT JOIN Customers c ON e.City = c.City
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL;


--Q10
SELECT TOP 1 e.City AS EmployeeCity, SUM(od.Quantity) As TotalOrderQuantity
FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.City
HAVING SUM(od.Quantity) = (
    SELECT TOP 1 SUM(od2.Quantity)
    FROM [Order Details] od2
    JOIN Orders o2 ON od2.OrderID = o2.OrderID
    JOIN Customers c2 ON o2.CustomerID = c2.CustomerID
    GROUP BY c2.City
    ORDER BY SUM(od2.Quantity) DESC
)
ORDER BY SUM(od.Quantity) DESC; --Such city is not existing

--Q11
/*
If you want to delete the duplicate rows from a table, you can use a CTE with ROW_NUMBER() 
to identify duplicates and then delete them.

WITH CTE AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY column1, column2, column3 ORDER BY (SELECT NULL)) AS rn
    FROM table_name
)
DELETE FROM CTE WHERE rn > 1;
*/
