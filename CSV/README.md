<!-- markdownlint-disable MD003 MD032 MD038 -->
# CSV 範本

## 階層

- 停車業管機關資料 [ParkingAuthorityList](ParkingAuthorityList.csv)
- 停車營運機關資料 [ParkingOperatorList](ParkingOperatorList.csv)
- 路外停車場基本資料 [CarParkList](CarParkList.csv)
    - 停車場區域 [CarParkList-ParkingAreas](CarParkList-ParkingAreas.csv)
- 路外停車場出入口資料 [ParkingEntranceExitList](ParkingEntranceExitList.csv)
    - 入口位置資訊 [ParkingEntranceExitList-Entrances](ParkingEntranceExitList-Entrances.csv)
    - 出口位置資訊 [ParkingEntranceExitList-Exits](ParkingEntranceExitList-Exits.csv)
    - 單一出入口位置資訊(出入口相同) [ParkingEntranceExitList-TwoInOne](ParkingEntranceExitList-TwoInOne.csv)

## 備註

1. 欄位名稱以星號`$`結尾的，代表選填欄位，例如 ``Geometry$`` => ``LINESTRING (121.55171 25.03800,121.55173 25.04080)``
2. 欄位名稱以加號`+`結尾的，代表此欄位可能包含多筆內容，例如 ``ParkingTypes+`` => ``{1,3}``，這種情況格式必須是``{第一筆,第二筆,...}``(大括號內仍需遵守csv規則)
