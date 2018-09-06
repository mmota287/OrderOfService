CREATE TABLE [dbo].[Order]
(
	[OrderId] BIGINT NOT NULL IDENTITY , 
    [Amount] DECIMAL(18, 2) NOT NULL, 
    [DateCreated] DATE NOT NULL, 
    [DateEnded] DATE NULL, 
    [Status] INT NOT NULL, 
    CONSTRAINT [PK_Order] PRIMARY KEY ([OrderId])
)

CREATE TABLE [dbo].[OrderItem]
(
	[OrderItemId] BIGINT NOT NULL IDENTITY , 
    [Product] VARCHAR(50) NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [Cost] DECIMAL(18, 2) NOT NULL, 
    [OrderId] BIGINT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([OrderItemId]), 
    CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([OrderId])
)
