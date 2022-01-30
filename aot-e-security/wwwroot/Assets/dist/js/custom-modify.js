$('button[type="reset"]').click(function () {
    window
        .location
        .reload();
})
$('input[required]').map((inp) => {
    var inpId = $('input[required]')[inp].id;
    $('label[for="' + inpId + '"]').addClass('required');
})
$('textarea[required]').map((inp) => {
    var inpId = $('textarea[required]')[inp].id;
    $('label[for="' + inpId + '"]').addClass('required');
})
$('select[required]').map((inp) => {
    var inpId = $('select[required]')[inp].id;
    $('label[for="' + inpId + '"]').addClass('required');
})