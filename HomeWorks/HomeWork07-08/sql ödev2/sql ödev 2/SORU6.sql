--Her bir çalışanın sorumlu olduğu bölgedeki (Territory) toplam satış miktarını hesaplayın.
SELECT e.EmployeeID, e.FirstName, e.LastName, t.TerritoryDescription, SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM Employees e
JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
JOIN Territories t ON et.TerritoryID = t.TerritoryID
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY e.EmployeeID, e.FirstName, e.LastName, t.TerritoryDescription
ORDER BY TotalSales DESC;
