﻿function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var regexS = "[\\?&]" + name + "=([^&#]*)";
    var regex = new RegExp(regexS);
    var results = regex.exec(window.location.search);
    if (results == null)
        return "";
    else
        return decodeURIComponent(results[1].replace(/\+/g, " "));
}

function GlassClass(name) {
    var self = this;
    self.name = name;
    self.detailsUrl = "/Details.gls?cls=" + name;
}

function GlassDetails(model) {
    var self = this;
    self.name = model.Name;
}

function GlassField(model) {
    var self = this;
    self.codeFirst = model.CodeFirst;
    self.fieldId = model.FieldId;
    self.fieldName = model.FieldName;
    self.fieldSource = model.FieldSource;
    self.fieldTitle = model.FieldTitle;
    self.fieldType = model.FieldType;
    self.name = model.Name;


}

function ModalOn(){
    $("body").addClass("loading");

}
function ModalOff() {
    $("body").removeClass("loading");
}