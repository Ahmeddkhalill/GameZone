$(document).ready(function () {

    $('#Cover').on('change', function () {

        if (this.files && this.files[0]) {

            $('.cover-preview')
                .attr('src', window.URL.createObjectURL(this.files[0]))
                .removeClass('d-none');
        }

    });

});