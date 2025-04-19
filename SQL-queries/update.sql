-- Suppose you want to update the order to use “DHL” as the carrier. First, find the carrier_id from the carriers table (say it’s 1) and the order_id (say it’s 10 for your new order)

UPDATE orders
SET carrier_id      = 1,        -- DHL
    tracking_number = 'DH123456789',
    shipped_date    = NOW(),
    order_status    = 'Shipped'
WHERE order_id = 1;


-- Once delivered, you set the delivered_date:

UPDATE orders
SET delivered_date = NOW(),
    order_status   = 'Delivered'
WHERE order_id = 1;


-- Update an Order to Use the Discount

UPDATE orders
SET discount_code_id = 1  -- referencing discount_codes.discount_code_id
WHERE order_id = 42;