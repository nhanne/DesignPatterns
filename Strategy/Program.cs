using Buoi1;

var normalStrategy = new NormalStrategy(); // chiến lược giá bình thường
var happyHourStrategy = new HappyHourStrategy(); // chiến lược giảm giá khung giờ bình thường
var firstCustomer = new CustomerBill(normalStrategy); // Tạo ra đối tượng khách hàng đầu tiên với chiến lược giá mặc định
// Normal billing
firstCustomer.Add(1.0, 1); // 1*1=1.0
// Start Happy Hour
firstCustomer.Strategy = happyHourStrategy; // thay đổi chiến lược giá cho kh đầu tiên sang giảm giá    
firstCustomer.Add(1.0, 2); // 1.0*2*0.5 = 1.0 
// New Customer
CustomerBill secondCustomer = new CustomerBill(happyHourStrategy);
secondCustomer.Add(0.8, 1); // 0.8*1*0.5= 0.4
// The Customer pays
firstCustomer.Print(); // in ra tổng bill kh đầu tiên: 1+1=2
// End Happy Hour
secondCustomer.Strategy = normalStrategy;  // chỉnh sửa chiến lượt giá về bình thường
secondCustomer.Add(1.3, 2); // kh thứ 2 mua thêm 2 đồ uống với giá là 1.3: 1.3*2=2.6
secondCustomer.Add(2.5, 1); // kh thứ 2 mua thêm 1 đồ uống với giá là 2.5: 2.5*1=2.5
secondCustomer.Print(); // 2.5+2.6+0.4 = 5.5     

