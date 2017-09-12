function initRegister() {
    var btnCust = '<button type="button" class="btn btn-default" title="Add picture tags" ' +
        'onclick="alert(\'Call your custom code here.\')">' +
        '<i class="glyphicon glyphicon-tag"></i>' +
        '</button>';
    var fileInput = $("#ProfileImage");
    var imageUrl = fileInput.data('profile');
    var imagePreviewSrc = imageUrl != null ? imageUrl : '/content/images/default_avatar_male.jpg';
    fileInput.fileinput({
        overwriteInitial: true,
        maxFileSize: 2048,
        showClose: false,
        showCaption: false,
        showBrowse: false,
        browseOnZoneClick: true,
        removeLabel: '',
        removeIcon: '<i class="glyphicon glyphicon-remove"></i>',
        removeTitle: 'Cancel or reset changes',
        elErrorContainer: '#kv-avatar-errors-2',
        msgErrorClass: 'alert alert-block alert-danger',
        defaultPreviewContent: '<img src="' + imagePreviewSrc + '" alt="Your Avatar" style="width:160px"><h6 class="text-muted">Click to select</h6>',
        layoutTemplates: { main2: '{preview} ' + ' {remove} {browse}' },
        allowedFileExtensions: ["jpg", "png", "gif"]
    });
    if (isEditingProfile)
    {
        $('#profile-tab a:last').tab('show')
    }
}

$(function () {
    initRegister();
});