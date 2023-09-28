insert into "ProductCookingDish" ("Id",
                                  "CookingDishId",
                                  "ProductId",
                                  "StartTime",
                                  "EndTime")
values (default,
        @CookingDishId,
        @ProductId,
        @StartTime,
        @EndTime) {0}"Id"