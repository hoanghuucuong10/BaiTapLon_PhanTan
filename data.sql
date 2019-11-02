UPDATE Dia 
SET HinhAnh = (SELECT * FROM OPENROWSET(BULK N'C:\Users\Admin\Desktop\ss\book.png', SINGLE_BLOB) as HinhAnh)