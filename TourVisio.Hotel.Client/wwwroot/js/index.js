$(document).ready(function() {

    $("[name='Child1']").change(function() {

        var value = $(this).val();
        for (i = 1; i <= 4; i++) {
            $("[name='ChildAge1" + i + "']").attr("disabled", value >= i ? false : true);
        }
    });

    $("[name='Child2']").change(function() {
        var value = $(this).val();
        for (i = 1; i <= 4; i++) {
            $("[name='ChildAge2" + i + "']").attr("disabled", value >= i ? false : true);
        }
    });

    $("[name='Child3']").change(function() {
        var value = $(this).val();
        for (i = 1; i <= 4; i++) {
            $("[name='ChildAge3" + i + "']").attr("disabled", value >= i ? false : true);
        }
    });

    $("[name='Child4']").change(function() {
        var value = $(this).val();
        for (i = 1; i <= 4; i++) {
            $("[name='ChildAge4" + i + "']").attr("disabled", value >= i ? false : true);
        }
    });

    $("[name='Room']").change(function() {
        var value = $(this).val();
        for (i = 1; i <= 4; i++) {
            $("[name='Adult" + i + "']").attr("disabled", value >= i ? false : true);
            $("[name='Child" + i + "']").val(0);
            $("[name='Child" + i + "']").attr("disabled", value >= i ? false : true);
            $("[name='ChildAge" + i + "1']").attr("disabled", true);
            $("[name='ChildAge" + i + "2']").attr("disabled", true);
            $("[name='ChildAge" + i + "3']").attr("disabled", true);
            $("[name='ChildAge" + i + "4']").attr("disabled", true);

            if (value >= i) {
                $("[name='roomRow" + i + "']").show();
            } else {
                $("[name='roomRow" + i + "']").hide();
            }
        }
    });

    $("[name='Location']").autocomplete({
        source: function(request, response) {
            $.getJSON("/Home/Location", request, function(data) {
                response($.map(data, function(item) {
                    var name = "";
                    var id = "";

                    let hotel = item.hotel == null ? "" : item.hotel.name;
                    let village = item.village == null ? "" : item.village.name;
                    let town = item.town == null ? "" : item.town.name;
                    let city = item.city == null ? "" : item.city.name;
                    let state = item.state == null ? "" : item.state.name;
                    let country = item.country == null ? "" : item.country.name;

                    switch (item.type) {

                        case 1:
                            id = item.city.id;

                            if (state == "") {
                                name = city;
                            } else {
                                name = city + " " + country;
                            }
                            break;

                        case 2:
                            id = item.hotel.id;
                            if (hotel == "") {
                                name = hotel;
                            } else {
                                name = hotel + " " + city + " " + country;
                            }
                            break;

                        case 4:
                            id = item.town.id;

                            if (town == "") {
                                name = town;
                            } else {
                                name = town + " " + hotel + " " + city + " " + country;
                            }
                            break;

                        case 5:
                            id = item.village.id;
                            if (village == "") {
                                name = village;
                            } else {
                                name = village + " " + town + " " + hotel + " " + city + " " + country;
                            }
                            break;

                        case 8:
                            id = item.country.id;
                            if (country == "") {
                                name = village + " " + town + " " + hotel + " " + city + " " + country;
                            }
                            break;
                        default:
                            break;
                    }

                    return {
                        label: name,
                        value: id
                    };
                }));
            });
        },
        select: function(event, ui) {
            $("[name='Location']").val(ui.item.label);
            $("[name='LocationId']").val(ui.item.value);
            $("[name='LocationType']").val(ui.item.value);
            return false;
        }
    });

    $("[name='btnPost']").click(function() {
        var searchForm = new Object();
        searchForm.Location = $("[name='Location']").val();
        searchForm.LocationId = $("[name='LocationId']").val();
        searchForm.LocationType = parseInt($("[name='LocationType']").val());
        searchForm.CheckInDate = $("[name='CheckInDate']").val();
        searchForm.CheckOutDate = $("[name='CheckOutDate']").val();
        searchForm.Nationality = $("[name='Nationality']").val();
        searchForm.Currency = $("[name='Currency']").val();
        searchForm.Room = parseInt($("[name='Room']").val());

        searchForm.Adult1 = $("[name='Adult1']").is(":disabled") ? 0 : parseInt($("[name='Adult1']").val());
        searchForm.Child1 = parseInt($("[name='Child1']").val());
        searchForm.ChildAge11 = $("[name='ChildAge11']").is(":disabled") ? 0 : parseInt($("[name='ChildAge11']").val());
        searchForm.ChildAge12 = $("[name='ChildAge12']").is(":disabled") ? 0 : parseInt($("[name='ChildAge12']").val());
        searchForm.ChildAge13 = $("[name='ChildAge13']").is(":disabled") ? 0 : parseInt($("[name='ChildAge13']").val());
        searchForm.ChildAge14 = $("[name='ChildAge14']").is(":disabled") ? 0 : parseInt($("[name='ChildAge14']").val());

        searchForm.Adult2 = $("[name='Adult2']").is(":disabled") ? 0 : parseInt($("[name='Adult2']").val());
        searchForm.Child2 = parseInt($("[name='Child2']").val());
        searchForm.ChildAge21 = $("[name='ChildAge21']").is(":disabled") ? 0 : parseInt($("[name='ChildAge21']").val());
        searchForm.ChildAge22 = $("[name='ChildAge22']").is(":disabled") ? 0 : parseInt($("[name='ChildAge22']").val());
        searchForm.ChildAge23 = $("[name='ChildAge23']").is(":disabled") ? 0 : parseInt($("[name='ChildAge23']").val());
        searchForm.ChildAge24 = $("[name='ChildAge24']").is(":disabled") ? 0 : parseInt($("[name='ChildAge24']").val());

        searchForm.Adult3 = $("[name='Adult3']").is(":disabled") ? 0 : parseInt($("[name='Adult3']").val());
        searchForm.Child3 = parseInt($("[name='Child3']").val());
        searchForm.ChildAge31 = $("[name='ChildAge31']").is(":disabled") ? 0 : parseInt($("[name='ChildAge31']").val());
        searchForm.ChildAge32 = $("[name='ChildAge32']").is(":disabled") ? 0 : parseInt($("[name='ChildAge32']").val());
        searchForm.ChildAge33 = $("[name='ChildAge33']").is(":disabled") ? 0 : parseInt($("[name='ChildAge33']").val());
        searchForm.ChildAge34 = $("[name='ChildAge34']").is(":disabled") ? 0 : parseInt($("[name='ChildAge34']").val());

        searchForm.Adult4 = $("[name='Adult4']").is(":disabled") ? 0 : parseInt($("[name='Adult4']").val());
        searchForm.Child4 = parseInt($("[name='Child4']").val());
        searchForm.ChildAge41 = $("[name='ChildAge41']").is(":disabled") ? 0 : parseInt($("[name='ChildAge41']").val());
        searchForm.ChildAge42 = $("[name='ChildAge42']").is(":disabled") ? 0 : parseInt($("[name='ChildAge42']").val());
        searchForm.ChildAge43 = $("[name='ChildAge43']").is(":disabled") ? 0 : parseInt($("[name='ChildAge43']").val());
        searchForm.ChildAge44 = $("[name='ChildAge44']").is(":disabled") ? 0 : parseInt($("[name='ChildAge44']").val());



        if (searchForm != null) {
            $.ajax({
                type: "POST",
                url: "/Home/Search",
                data: JSON.stringify(searchForm),
                contentType: "application/json; charset=utf-8",
                dataType: "html",
                success: function(response) {
                    $('#searchResult').html(response);
                },
                failure: function(response) {
                    alert(response.responseText);
                },
                error: function(response) {
                    alert(response.responseText);
                }
            });
        }
    });

    $("#searchResult").on("click", ".hotel", function() {
        var id = $(this).attr("id");
        $("[name='offers" + id + "']").toggle();
    });

    $("#searchResult").on("click", ".book", function() {
        var id = $(this).attr("offerId");
        window.location.href = "/Home/Reservation?offerId=" + id + "&currency=" + $("[name='Currency']").val();
    });

    $("[name='btnBook']").click(function() {

        var roomCount = $("[name='RoomCount']").val();

        var resForm = new Object();
        var transactionId = $("[name='TransactionId']").val();
        resForm.TransactionId = transactionId;

        var currency = $("[name='Currency']").val();
        resForm.Currency = currency;

        var agencyResNumber = $("[name='AgencyReservationNumber']").val();
        resForm.AgencyReservationNumber = agencyResNumber;

        var resInfo = $("[name='ReservationInfo']").val();
        resForm.ReservationInfo = resInfo;

        var customerInfo = $("[name='CustomerInfo']").val();
        resForm.CustomerInfo = customerInfo;

        var rooms = new Array();

        for (var r = 1; r <= roomCount; r++) {
            var travellerCount = $("[name='TravellerCount" + r + "']").val();
            var room = new Object();
            room.RoomNumber = r;
            var travellers = new Array();

            for (var t = 1; t <= travellerCount; t++) {
                var traveller = new Object();
                traveller.Title = $("[name='title" + r + t + "']").val();
                traveller.Name = $("[name='Name" + r + t + "']").val();
                traveller.Surname = $("[name='Surname" + r + t + "']").val();
                traveller.Nationality = $("[name='Nationality" + r + t + "']").val();
                traveller.Code = $("[name='Code" + r + t + "']").val();
                traveller.PhoneNumber = $("[name='PhoneNumber" + r + t + "']").val();
                traveller.PassportNo = $("[name='PassportNo" + r + t + "']").val();
                traveller.ExpireDate = $("[name='ExpireDate" + r + t + "']").val();
                traveller.IssueDate = $("[name='IssueDate" + r + t + "']").val();
                traveller.IssueCountry = $("[name='IssueCountry" + r + t + "']").val();

                travellers.push(traveller);
            }
            room.Travellers = travellers;
            rooms.push(room);
        }
        resForm.Rooms = rooms;
        if (resForm != null) {
            $.ajax({
                type: "POST",
                url: "/Home/Booking",
                data: JSON.stringify(resForm),
                contentType: "application/json; charset=utf-8",
                dataType: "html",
                success: function(response) {
                    $('#reservationResult').html(response);
                },
                failure: function(response) {
                    alert(response.responseText);
                },
                error: function(response) {
                    alert(response.responseText);
                }
            });
        }
    });
});