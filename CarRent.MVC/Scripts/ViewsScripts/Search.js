// here i am to write a JS for the search operations

$(function () {

    //$('#search-btn').click(function () {
    //    console.log("It Works")
    //})


    //$('.searcher').change(function () {

    //    console.log('Changed');
    //    var caurrentId = $(this).attr('id');
    //    var currentval = $(this).val();

    //})

    var srch_btn = $('#search-btn')
    var srch_selections = $('#search-panel:selected').val();
    var updateCarList = function (resp) {
       // $('#car-list-displayed.list-group-item').remove();
   //     for (var item in resp) {
        //   $('#car-list-displayed.list-group-item').append($("<li></li>").text(item.Name));
      //  $.each(resp, function (a, b) { $('#car-list-displayed.list-group-item').append($("<li></li>").text(b.Name)); });
       
        
       // $('#car-list-displayed').appe;


        for (var i = 0; i < resp.length; i++) {
            var newRow = $('.new-car').clone().removeClass('new-car');
            var newElemValues = {"a":"b","c":"d"};
            $("<div>", newElemValues).appendTo(newRow);
            //newRow.find('.ID span').text(resp[i].ID);


            //for (var propName in resp[i]) {
            //    newRow.find('td.' + propName).find('input').val(resp[i][propName]);
            //}
            //newRow.find('.CategoryID').find('option[value="' + resp[i].CategoryID + '"]').prop('selected', true);
            //newRow.find('.SupplierID').find('option[value="' + resp[i].SupplierID + '"]').prop('selected', true);
            //newRow.find('button').text('Update');
            newRow.appendTo('#car-list-displayed');
        }



    }

    //$(function () {
    //    $.getJSON('@Url.Action("GetProducts")', function (prodArray) {
    //        for (var i = 0; i < prodArray.length; i++) {
    //            var newRow = $('.new-product').clone().removeClass('new-product');
    //            newRow.find('.ID span').text(prodArray[i].ID);
    //            for (var propName in prodArray[i]) {
    //                newRow.find('td.' + propName).find('input').val(prodArray[i][propName]);
    //            }
    //            newRow.find('.CategoryID').find('option[value="' + prodArray[i].CategoryID + '"]').prop('selected', true);
    //            newRow.find('.SupplierID').find('option[value="' + prodArray[i].SupplierID + '"]').prop('selected', true);
    //            newRow.find('button').text('Update');
    //            newRow.appendTo('tbody');
    //        }
    //    });
    //})





    var printError = function (req, status, err) {
        console.log('Fail to proccess function, got error:', status, err);
    }
    var ajaxOptions = {
        url: "/Search/GetCarsByCriterion",
        //cretiria:srch_selections,
        dataType: "json",
        //  traditional: true,
        // contentType:"application/json; charset=utf-8",
        type: "POST",
        success:updateCarList,
           // function (response) {
            //return alert("updateCarList")
      //  },
        error: printError
    }
    srch_btn.click(function () {
        // var caurrentId = $('.ModelTypeSelect :selected').attr('selected', 'selected').val();
        var currentFreeTextSearch = $('.FreeSearchText input');
        var currentFreeTextSearchSrting = currentFreeTextSearch.val();
        var currentGearTypeSelection = $('.GearSelect :selected');
        var currentGearTypeSelection = $('.GearSelect :selected').attr('selected', 'selected');
        var currentGearTypeval = currentGearTypeSelection.val();
        var currentModelTypeSelection = $('.ModelTypeSelect :selected').attr('selected', 'selected');
        var currentModelTypeval = currentModelTypeSelection.val();

        //var myData = JSON.stringify({
           var  Cretiria = {
                'SearchGear': currentGearTypeval,
                'SearchModel': currentModelTypeval,
                'SearchText': currentFreeTextSearchSrting
            }
        //});
        //ajaxOptions['data'] = { 'Cretiria': myData };
    //    ajaxOptions['data'] = myData;
           ajaxOptions['data'] = Cretiria;
        $.ajax(ajaxOptions)
    })
});

