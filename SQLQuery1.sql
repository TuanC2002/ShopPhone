CREATE DATABASE SHOPPING_MOBIPHONE;
USE SHOPPING_MOBIPHONE
CREATE TABLE PHONE_INFO(
ID INT NOT NULL IDENTITY(1,1),
NAME_PHONE VARCHAR(255) NOT NULL,
COMPANY VARCHAR(255) NOT NULL,
ROM INT NOT NULL,
RAM INT NOT NULL,
CATEGORY VARCHAR(255) NOT NULL,
PRICE INT NOT NULL,
COUNT_CLICK INT
);

ALTER TABLE PHONE_INFO ADD CONSTRAINT PK_PHONE PRIMARY KEY (ID);
UPDATE PHONE_INFO 
SET COUNT_CLICK = 0;
UPDATE PHONE_INFO 
SET PRICE = 25500000 WHERE ID = 65;
--
CREATE TABLE DON_HANG(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ID_PHONE VARCHAR(255),
COLOR VARCHAR(255),
SO_LUONG INT 
);
CREATE TABLE VOUCHER(
CODE NVARCHAR(255)PRIMARY KEY,
PRICE INT
);
--
CREATE TABLE INFO(
NAME_SERIES NVARCHAR(255) PRIMARY KEY NOT NULL,
SIZE_SCREEN NVARCHAR(255) NOT NULL,
TECH_SCREEN NVARCHAR(255) NOT NULL,
HZ			NVARCHAR(255) NOT NULL,
CAM_BEHIND NVARCHAR(255) NOT NULL,
VIDEO_BEHIND NVARCHAR(255) NOT NULL,
TECH_BEHIND NVARCHAR(255) NOT NULL,
CAM_FRONT NVARCHAR(255) NOT NULL,
VIDEO_FRONT NVARCHAR(255) NOT NULL,
CHIP NVARCHAR(255) NOT NULL,
GPU NVARCHAR(255) NOT NULL,
PIN NVARCHAR(255) NOT NULL,
TECH_PIN NVARCHAR(255) NOT NULL,
PORT_PIN NVARCHAR(255) NOT NULL,
SIM NVARCHAR(255) NOT NULL,
OS NVARCHAR(255) NOT NULL,
JACK NVARCHAR(255) NOT NULL,
WIFI NVARCHAR(255) NOT NULL,
SIZE_PHONE NVARCHAR(255) NOT NULL,
WEIGHT_PHONE NVARCHAR(255) NOT NULL,
FINGERPRINT NVARCHAR(255) NOT NULL,
SENSOR NVARCHAR(255) NOT NULL,
SPECIAL NVARCHAR(255) NOT NULL
);

CREATE TABLE DS_DON_HANG(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NAME_CUS NVARCHAR(255),
PHONE_NUMBER VARCHAR(255),
HOME NVARCHAR(255),
VOUCHER INT,
FinalPrice VARCHAR(255),
);

--iphone14
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14', 'Apple', 128, 6, 'Iphone 14 series', 21990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14', 'Apple', 256, 6, 'Iphone 14 series', 23990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14', 'Apple', 512, 6, 'Iphone 14 series', 28990000);
--iphone14 pro
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro', 'Apple', 128, 6, 'Iphone 14 series', 30490000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro', 'Apple', 256, 6, 'Iphone 14 series', 32490000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro', 'Apple', 512, 6, 'Iphone 14 series', 35990000);
--iphone14 pro max 
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro max', 'Apple', 128, 6, 'Iphone 14 series', 33990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro max', 'Apple', 256, 6, 'Iphone 14 series', 36990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 14 pro max', 'Apple', 512, 6, 'Iphone 14 series', 43990000);
--iphone13
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13', 'Apple', 256, 4, 'Iphone 13 series', 21290000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13', 'Apple', 512, 4, 'Iphone 13 series', 2550000);
--iphone13 pro 
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro', 'Apple', 128, 4, 'Iphone 13 series', 25990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro', 'Apple', 256, 4, 'Iphone 13 series', 27990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro', 'Apple', 512, 4, 'Iphone 13 series', 31990000);
--iphone13 pro max
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro max', 'Apple', 128, 4, 'Iphone 13 series', 27990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro max', 'Apple', 256, 4, 'Iphone 13 series', 30990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 13 pro max', 'Apple', 512, 4, 'Iphone 13 series', 34990000);
--iphone 12 
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12', 'Apple', 64, 4, 'Iphone 12 series', 16790000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12', 'Apple', 128, 4, 'Iphone 12 series', 16990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12', 'Apple', 256, 4, 'Iphone 12 series', 19990000);
--iphone 12 pro
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro', 'Apple', 128, 4, 'Iphone 12 series', 24990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro', 'Apple', 512, 4, 'Iphone 12 series', 27500000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro', 'Apple', 256, 4, 'Iphone 12 series', 24990000);
--iphone 12 pro max
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro max', 'Apple', 128, 4, 'Iphone 12 series', 25590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro max', 'Apple', 512, 4, 'Iphone 12 series', 27590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Iphone 12 pro max', 'Apple', 256, 4, 'Iphone 12 series', 33000000);
--samsung z
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Z Fold4', 'Sam sung', 256, 12, 'Sam sung Z Fold series', 36290000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Z Fold4', 'Sam sung', 512, 12, 'Sam sung Z Fold series', 39790000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Z Flip4', 'Sam sung', 128, 8, 'Sam sung Z  Flip series', 20590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Z Flip4', 'Sam sung', 256, 8, 'Sam sung Z Flip series', 22590000);
--ss note
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Note 20 Ultra', 'Sam sung', 256, 8, 'Sam sung Note series', 19200000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Note 20', 'Sam sung', 512, 12, 'Sam sung Note series', 15000000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy Z Note 20 Ultra', 'Sam sung', 128, 8, 'Sam sung Note series', 18990000);
-- ss S
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy S22', 'Sam sung', 128, 8, 'Sam sung S series', 15590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy S22', 'Sam sung', 256, 8, 'Sam sung S series', 15990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy S22 Ultra 5G', 'Sam sung', 128, 8, 'Sam sung S series', 24890000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy S22 Ultra 5G', 'Sam sung', 256, 12, 'Sam sung S series', 26950000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy S22 Ultra 5G', 'Sam sung', 512, 12, 'Sam sung S series', 29850000);
--ss A
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A13 (4G)', 'Sam sung', 128, 4, 'Sam sung A series', 3990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A73 (5G)', 'Sam sung', 128, 8, 'Sam sung A series', 10070000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A73 (5G)', 'Sam sung', 256, 8, 'Sam sung A series', 10790000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A33 (5G)', 'Sam sung', 128, 6, 'Sam sung A series', 6900000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A53 (5G)', 'Sam sung', 128, 8, 'Sam sung A series', 8050000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Samsung Galaxy A23', 'Sam sung', 128, 4, 'Sam sung A series', 5350000);
--xiaomi poco
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Poco F4', 'Xiaomi', 128, 6, 'POCO', 8190000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('POCO X4 GT', 'Xiaomi', 128, 8, 'POCO', 7690000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('POCO X4 GT', 'Xiaomi', 256, 8, 'POCO', 8590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi POCO M5', 'Xiaomi', 64, 4, 'POCO', 3790000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi POCO M5', 'Xiaomi', 128, 6, 'POCO', 4450000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi POCO M5s', 'Xiaomi', 64, 4, 'POCO', 4050000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi POCO M5s', 'Xiaomi', 128, 6, 'POCO', 4990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi POCO M5s', 'Xiaomi', 128, 6, 'POCO', 4990000);
--redmi 9 series
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 9T', 'Xiaomi', 128, 6, 'Redmi 9 series', 4400000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 9T', 'Xiaomi', 64, 4, 'Redmi 9 series', 3990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 9C', 'Xiaomi', 64, 3, 'Redmi 9 series', 2750000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 9C', 'Xiaomi', 128, 4, 'Redmi 9 series', 2850000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 9A', 'Xiaomi', 32, 2, 'Redmi 9 series', 2000000);
--redmi 10 series
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 10C', 'Xiaomi', 128, 4, 'Redmi 10 series', 3550000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 10', 'Xiaomi', 128, 4, 'Redmi 10 series', 3950000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 10', 'Xiaomi', 64, 4, 'Redmi 10 series', 3250000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi 10A', 'Xiaomi', 32, 2, 'Redmi 10 series', 2500000);
--xiaomi note 11
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi Note 11S', 'Xiaomi', 128, 8, 'Xiaomi Note 11 series', 6090000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi Note 11 Pro Plus 5G', 'Xiaomi', 128, 8, 'Xiaomi Note 11 series', 8890000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi Note 11', 'Xiaomi', 128, 4, 'Xiaomi Note 11 series', 4590000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi Redmi Note 11', 'Xiaomi', 64, 4, ' Xiaomi Note 11 series', 420000);
--xiaomi 12 series
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi 12T Pro', 'Xiaomi', 256, 12, 'Xiaomi 12 series', 16990000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi 12T', 'Xiaomi', 128, 8, ' Xiaomi 12 series', 12490000);
INSERT INTO PHONE_INFO (NAME_PHONE, COMPANY, ROM, RAM, CATEGORY, PRICE)
VALUES ('Xiaomi 12 (5G)', 'Xiaomi', 256, 8, 'Xiaomi 12 series', 15790000);
-- Information
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Iphone 12 series', '6.1 inches', 'OLED',N'Tần số quét 60Hz', N'Camera góc rộng: 12MP 
Camera góc siêu rộng: 12MP', N'_',N'_',N'_',N'_',
		'Apple A15 Bionic', N'_', '3,279mAh', 'Sạc nhanh 20W','Lightning',N'2 SIM (nano‑SIM và eSIM)', 'iOS16', N'Không', 'Wi-Fi MIMO, Dual-band (2.4 GHz/5 GHz), Wi-Fi 802.11 a/b/g/n/ac/ax, Wi-Fi hotspot',
		N'_',N'_',N'_',N'_',N'_' );
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Iphone 13 series', '6.1 inches', 'OLED', N'Tần số quét 120Hz', N'Camera chính: 48MP 
Camera góc siêu rộng: 12MP 
Camera tele: 12MP', N'4K @24 fps, 25 fps, 30 fps, 60 fps 
1080p @25 fps, 30 fps, 60 fps 
720p @30 fps 
4K HDR @30 fps 
2.8K @ 60 fps 
HDR với Dolby Vision @60 fps 
ProRes 4K @30fps 
Chuyển động chậm 1080p @ 120fps, 240 fps',
N'Zoom quang học 6x
Zoom kỹ thuật số lên đến 15x
Đèn flash True Tone
HDR
Chân dung với bokeh
Chế độ ban đêm
Chụp chân dung đêm
Toàn cảnh (lên đến 63MP) (LiDAR Scanner)
Apple ProRAW
Smart HDR 4', N'12MP',N'4K @24 fps, 25 fps, 30 fps or 60 fps
1080p @25 fps, 30 fps or 60 fps
4K HDR @30 fps
HDR với Dolby Vision 4K @60fps
ProRes 4K @30fps
Slow-motion 1080p @240fps', N'Apple A16 Bionic', N'GPU 5 nhân', '3.200mAh', N'Sạc nhanh Sạc lên đến 15W', 'Lightning', N'2 SIM (nano‑SIM và eSIM)', 'iOS16', N'Không', N'Wi‑Fi 6 (802.11ax) with 2x2 MIMO', N'_',N'_', '0',	N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển, Cảm biến áp kế', N'Hỗ trợ 5G, Sạc không dây, Nhận diện khuôn mặt, Kháng nước, kháng bụi'); 

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Iphone 14 series', '6.1 inches', 'OLED', N'Tần số quét 120Hz', N'Camera chính: 48MP 
Camera góc siêu rộng: 12MP 
Camera tele: 12MP', N'4K @24 fps, 25 fps, 30 fps, 60 fps 
1080p @25 fps, 30 fps, 60 fps 
720p @30 fps 
4K HDR @30 fps 
2.8K @ 60 fps 
HDR với Dolby Vision @60 fps 
ProRes 4K @30fps 
Chuyển động chậm 1080p @ 120fps, 240 fps',
N'Zoom quang học 6x
Zoom kỹ thuật số lên đến 15x
Đèn flash True Tone
HDR
Chân dung với bokeh
Chế độ ban đêm
Chụp chân dung đêm
Toàn cảnh (lên đến 63MP) (LiDAR Scanner)
Apple ProRAW
Smart HDR 4', N'12MP',N'4K @24 fps, 25 fps, 30 fps or 60 fps
1080p @25 fps, 30 fps or 60 fps
4K HDR @30 fps
HDR với Dolby Vision 4K @60fps
ProRes 4K @30fps
Slow-motion 1080p @240fps', N'Apple A16 Bionic', N'GPU 5 nhân', '3.200mAh', N'Sạc nhanh
Sạc MagSafe lên đến 15W', 'Lightning', N'2 SIM (nano‑SIM và eSIM)', 'iOS16', N'Không', N'Wi‑Fi 6 (802.11ax) with 2x2 MIMO', N'_',N'_', '0',	N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển, Cảm biến áp kế', N'Hỗ trợ 5G, Sạc không dây, Nhận diện khuôn mặt, Kháng nước, kháng bụi'); 
--11 series
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Iphone 11 series', '6.1 inches', 'OLED', N'Tần số quét 120Hz', N'Camera chính: 48MP 
Camera góc siêu rộng: 12MP 
Camera tele: 12MP', N'4K @24 fps, 25 fps, 30 fps, 60 fps 
1080p @25 fps, 30 fps, 60 fps 
720p @30 fps 
4K HDR @30 fps 
2.8K @ 60 fps 
HDR với Dolby Vision @60 fps 
ProRes 4K @30fps 
Chuyển động chậm 1080p @ 120fps, 240 fps',
N'Zoom quang học 6x
Zoom kỹ thuật số lên đến 15x
Đèn flash True Tone
HDR
Chân dung với bokeh
Chế độ ban đêm
Chụp chân dung đêm
Toàn cảnh (lên đến 63MP) (LiDAR Scanner)
Apple ProRAW
Smart HDR 4', N'12MP',N'4K @24 fps, 25 fps, 30 fps or 60 fps
1080p @25 fps, 30 fps or 60 fps
4K HDR @30 fps
HDR với Dolby Vision 4K @60fps
ProRes 4K @30fps
Slow-motion 1080p @240fps', N'Apple A16 Bionic', N'GPU 5 nhân', '3.200mAh', N'Sạc nhanh
Sạc MagSafe lên đến 15W', 'Lightning', N'2 SIM (nano‑SIM và eSIM)', 'iOS16', N'Không', N'Wi‑Fi 6 (802.11ax) with 2x2 MIMO', N'_',N'_', '0',	N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển, Cảm biến áp kế', N'Hỗ trợ 5G, Sạc không dây, Nhận diện khuôn mặt, Kháng nước, kháng bụi'); 
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Sam sung Z Flip series', '6.7 inches', 'Dynamic AMOLED 2X', '120Hz', N'Camera góc rộng: 12 MP, f/1.8, PDAF, OIS
Camera góc siêu rộng: 12 MP, f/1.12, 123˚', N'4K@30/60fps, 1080p@60/240fps, 720p@960fps, HDR10+', '', '10 MP, f/2.4', '4K@30fps', 'Snapdragon 8+ Gen 1 (4 nm)', 'Adreno 730',
'3700 mAh', N'Sạc nhanh 25W
Sạc nhanh không dây 10W
Sạc không dây ngược 4,5W', 'Micro-USB', '2 SIM (nano‑SIM và eSIM)', 'Android 12, One UI 4.1.1', N'Không', 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','','',N'Cảm biến vân tay trong màn hình',
N'Cảm biến gia tốc, Cảm biến tiệm cận, La bàn, Con quay hồi chuyển, Cảm biến áp kế', N'Chỉ số kháng nước, bụi: IPX8');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('Sam sung Z Fold series', '6.7 inches', 'Dynamic AMOLED 2X', '120Hz', N'Camera góc rộng: 12 MP, f/1.8, PDAF, OIS
Camera góc siêu rộng: 12 MP, f/1.12, 123˚', N'4K@30/60fps, 1080p@60/240fps, 720p@960fps, HDR10+', '', '10 MP, f/2.4', '4K@30fps', 'Snapdragon 8+ Gen 1 (4 nm)', 'Adreno 730',
'3700 mAh', N'Sạc nhanh 25W
Sạc nhanh không dây 10W
Sạc không dây ngược 4,5W', 'Micro-USB', '2 SIM (nano‑SIM và eSIM)', 'Android 12, One UI 4.1.1', N'Không', 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','','',N'Cảm biến vân tay trong màn hình',
N'Cảm biến gia tốc, Cảm biến tiệm cận, La bàn, Con quay hồi chuyển, Cảm biến áp kế', N'Chỉ số kháng nước, bụi: IPX8');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Sam sung Note series', '6.9 inches', 'Dynamic AMOLED 2X capacitive touchscreen, 16M colorsDynamic AMOLED 2X, 16M colors, Corning Gorilla Glass Victus, HDR10+, Always-on display, 120Hz@FHD/60Hz@QHD refresh rate',
'120Hz', '108 MP, f/1.8, 26mm (wide), 1/1.33", 0.8µm, PDAF, Laser AF, OIS
12 MP, f/3.0, 103mm (periscope telephoto), 1.0µm, PDAF, OIS, 5x optical zoom, 50x hybrid zoom
12 MP, f/2.2, 13mm (ultrawide), 1/2.55", 1.4µm', '8K@24fps, 4K@30/60fps, 1080p@30/60/240fps, 720p@960fps, HDR10+, stereo sound rec., gyro-EIS & OIS', '_', '10 MP, f/2.2, 26mm (wide), 1/3.2", 1.22µm, Dual Pixel PDAF',
'4K@30/60fps, 1080p@30fps', 'Exynos 990 (7 nm+)', 'Mali-G77 MP11', '4500 mAh', 'Fast charging 25W', 'USB Power Delivery 3.0', '2 SIM (Nano-SIM)', 'Android 10, One UI 2.1',
N'Không', 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot', '_', '_','_',N'Cảm biến vân tay siêu âm, cảm biến gia tốc, cảm biến tiệm cận, cảm biến sáng, con quay hồi chuyển, la bàn, cảm biến áp kế','');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Sam sung S series', '6.9 inches', 'Dynamic AMOLED 2X capacitive touchscreen, 16M colorsDynamic AMOLED 2X, 16M colors, Corning Gorilla Glass Victus, HDR10+, Always-on display, 120Hz@FHD/60Hz@QHD refresh rate',
'120Hz', '108 MP, f/1.8, 26mm (wide), 1/1.33", 0.8µm, PDAF, Laser AF, OIS
12 MP, f/3.0, 103mm (periscope telephoto), 1.0µm, PDAF, OIS, 5x optical zoom, 50x hybrid zoom
12 MP, f/2.2, 13mm (ultrawide), 1/2.55", 1.4µm', '8K@24fps, 4K@30/60fps, 1080p@30/60/240fps, 720p@960fps, HDR10+, stereo sound rec., gyro-EIS & OIS', '_', '10 MP, f/2.2, 26mm (wide), 1/3.2", 1.22µm, Dual Pixel PDAF',
'4K@30/60fps, 1080p@30fps', 'Exynos 990 (7 nm+)', 'Mali-G77 MP11', '4500 mAh', 'Fast charging 25W', 'USB Power Delivery 3.0', '2 SIM (Nano-SIM)', 'Android 10, One UI 2.1',
N'Không', 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot', '_', '_','_',N'Cảm biến vân tay siêu âm, cảm biến gia tốc, cảm biến tiệm cận, cảm biến sáng, con quay hồi chuyển, la bàn, cảm biến áp kế','');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Sam sung A series', '6.9 inches', 'Dynamic AMOLED 2X capacitive touchscreen, 16M colorsDynamic AMOLED 2X, 16M colors, Corning Gorilla Glass Victus, HDR10+, Always-on display, 120Hz@FHD/60Hz@QHD refresh rate',
'120Hz', '108 MP, f/1.8, 26mm (wide), 1/1.33", 0.8µm, PDAF, Laser AF, OIS
12 MP, f/3.0, 103mm (periscope telephoto), 1.0µm, PDAF, OIS, 5x optical zoom, 50x hybrid zoom
12 MP, f/2.2, 13mm (ultrawide), 1/2.55", 1.4µm', '8K@24fps, 4K@30/60fps, 1080p@30/60/240fps, 720p@960fps, HDR10+, stereo sound rec., gyro-EIS & OIS', '_', '10 MP, f/2.2, 26mm (wide), 1/3.2", 1.22µm, Dual Pixel PDAF',
'4K@30/60fps, 1080p@30fps', 'Exynos 1280 ', 'Mali-G68', '4500 mAh', 'Fast charging 25W', 'USB Power Delivery 3.0', '2 SIM (Nano-SIM)', 'Android 10, One UI 2.1',
N'Không', 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot', '_', '_','_',N'Cảm biến vân tay siêu âm, cảm biến gia tốc, cảm biến tiệm cận, cảm biến sáng, con quay hồi chuyển, la bàn, cảm biến áp kế','');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES ('POCO','6.6 inches', 'IPS LCD', '144Hz', 'Camera góc rộng: 64 MP, f/1.89
Camera góc siêu rộng: 8 MP, f/2.2, 120˚
Camera macro: 2 MP, f/2.4, 1,75μm', '4K@30fps, 1080p@30/60fps', N'LED flash
HDR
Chụp toàn cảnh
AI camera
Phơi sáng
AI làm đẹp
Chân dung
Bộ lọc
Chế độ ban đêm
Movie frame
Chế độ chuyên nghiệp
Timed-burst
Photo clones
Chế độ tài liệu', N'Camera góc rộng: 16 MP, f/2.45', '1080p@30fps', 'MediaTek Dimensity 8100', 'Mali-G610 MC6', ' 5080 mAh', N'Sạc nhanh 67W','USB Type-C', N'2 SIM (Nano-SIM)',
'Android 12, MIUI 13', 1, 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot', '', '',N'Cảm biến vân tay cạnh bên',N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển',N'Hỗ trợ 5G, Bảo mật vân tay, Nhận diện khuôn mặt');
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Xiaomi Note 11 series','6.67 inches', 'AMOLED', '120Hz', N'Camera góc rộng: 108 MP, f/1.9, PDAF
Camera góc siêu rộng: 8 MP
Camera Tele: 2 MP, f/2.4
Camera chân dung: 2MP f/2.4', N'1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', '164.19 x 76.1 x 8.12mm', '16MP f/2.4','1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', 'MediaTek Helio G96','ARM Mali-G57 MC2', '5000mAh (typ)', 'Sạc nhanh 67W
hỗ trợ giao thức sạc nhanh QC3 + / PD2.0 / PD3.0','USB Type-C','2 SIM (Nano-SIM)','Android 11, MIUI 12.5',1,'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','163.7 x 76.2 x 8.3 mm', '202g',
N'Cảm biến vân tay cạnh bên', N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển',	N'Bảo mật vân tay, Nhận diện khuôn mặt');
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Xiaomi 12 series','6.67 inches', 'AMOLED', '120Hz', N'Camera góc rộng: 108 MP, f/1.9, PDAF
Camera góc siêu rộng: 8 MP
Camera Tele: 2 MP, f/2.4
Camera chân dung: 2MP f/2.4', N'1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', '164.19 x 76.1 x 8.12mm', '16MP f/2.4','1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', 'MediaTek Helio G96','ARM Mali-G57 MC2', '5000mAh (typ)', 'Sạc nhanh 67W
hỗ trợ giao thức sạc nhanh QC3 + / PD2.0 / PD3.0','USB Type-C','2 SIM (Nano-SIM)','Android 11, MIUI 12.5',1,'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','163.7 x 76.2 x 8.3 mm', '202g',
N'Cảm biến vân tay cạnh bên', N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển',	N'Bảo mật vân tay, Nhận diện khuôn mặt');
INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Redmi 9 series','6.67 inches', 'AMOLED', '120Hz', N'Camera góc rộng: 108 MP, f/1.9, PDAF
Camera góc siêu rộng: 8 MP
Camera Tele: 2 MP, f/2.4
Camera chân dung: 2MP f/2.4', N'1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', '164.19 x 76.1 x 8.12mm', '16MP f/2.4','1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', 'MediaTek Helio G96','ARM Mali-G57 MC2', '5000mAh (typ)', 'Sạc nhanh 67W
hỗ trợ giao thức sạc nhanh QC3 + / PD2.0 / PD3.0','USB Type-C','2 SIM (Nano-SIM)','Android 11, MIUI 12.5',1,'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','163.7 x 76.2 x 8.3 mm', '202g',
N'Cảm biến vân tay cạnh bên', N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển',	N'Bảo mật vân tay, Nhận diện khuôn mặt');

INSERT INTO INFO (NAME_SERIES, SIZE_SCREEN, TECH_SCREEN, HZ, CAM_BEHIND, VIDEO_BEHIND, TECH_BEHIND,CAM_FRONT, VIDEO_FRONT, CHIP, GPU, PIN, TECH_PIN,
PORT_PIN, SIM, OS, JACK, WIFI, SIZE_PHONE, WEIGHT_PHONE, FINGERPRINT, SENSOR, SPECIAL)
VALUES('Redmi 10 series','6.67 inches', 'AMOLED', '120Hz', N'Camera góc rộng: 108 MP, f/1.9, PDAF
Camera góc siêu rộng: 8 MP
Camera Tele: 2 MP, f/2.4
Camera chân dung: 2MP f/2.4', N'1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', '164.19 x 76.1 x 8.12mm', '16MP f/2.4','1080p 1920x1080 | 30fps
720p 1280x720 | 30fps', 'MediaTek Helio G96','ARM Mali-G57 MC2', '5000mAh (typ)', 'Sạc nhanh 67W
hỗ trợ giao thức sạc nhanh QC3 + / PD2.0 / PD3.0','USB Type-C','2 SIM (Nano-SIM)','Android 11, MIUI 12.5',1,'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct, hotspot','163.7 x 76.2 x 8.3 mm', '202g',
N'Cảm biến vân tay cạnh bên', N'Cảm biến gia tốc, Cảm biến tiệm cận, Cảm biến ánh sáng, La bàn, Con quay hồi chuyển',	N'Bảo mật vân tay, Nhận diện khuôn mặt');
DELETE FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO 
SELECT * FROM DON_HANG
SELECT * FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO 
SELECT * FROM SHOPPING_MOBIPHONE.dbo.DON_HANG NAME_PHONE WHERE ID_PHONE = 27 
SELECT * FROM VOUCHER
INSERT INTO SHOPPING_MOBIPHONE.dbo.DON_HANG (ID_PHONE, COLOR, SO_LUONG) VALUES ('1', 'black',1);
INSERT INTO VOUCHER(CODE, PRICE)
VALUES('1111', 500000)
SELECT * FROM VOUCHER
SELECT * FROM SHOPPING_MOBIPHONE.dbo.DS_DON_HANG
--------------------------------
SELECT SHOPPING_MOBIPHONE.dbo.PHONE_INFO.NAME_PHONE, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.RAM, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.ROM, SHOPPING_MOBIPHONE.dbo.PHONE_INFO.PRICE,SHOPPING_MOBIPHONE.dbo.DON_HANG.COLOR,SHOPPING_MOBIPHONE.dbo.DON_HANG.SO_LUONG  INTO DS_PHONE
FROM SHOPPING_MOBIPHONE.dbo.PHONE_INFO , SHOPPING_MOBIPHONE.dbo.DON_HANG
WHERE SHOPPING_MOBIPHONE.dbo.DON_HANG.ID = SHOPPING_MOBIPHONE.dbo.PHONE_INFO.ID 
----------------------------------- DS_PHONE + ID DS_DON_HANG

SELECT * FROM DS_PHONE1
INSERT INTO SHOPPING_MOBIPHONE.dbo.DS_DON_HANG(NAME_CUS, PHONE_NUMBER,HOME,VOUCHER)
VALUES ('Iphone 12 pro', 'Apple', 128, 4, 'Iphone 12 series', 24990000);
