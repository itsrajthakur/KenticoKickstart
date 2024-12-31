using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kickstart;

// Widgets

// Sections
[assembly: RegisterSection(identifier: ComponentIdentifiers.SINGLE_COLUMN_SECTION,name: "1 column",customViewName: "~/Components/Sections/_Kickstart_SingleColumnSection.cshtml",Description = "Single-column section with one full-width zone.",IconClass = "icon-square")]
[assembly: RegisterSection(ComponentIdentifiers.TWO_COLUMN_SECTION, "2 columns - 50/50", customViewName: "~/Components/Sections/_Kickstart_TwoColumnSection.cshtml", Description = "Two-column section with zones layout 50% + 50%.", IconClass = "icon-l-cols-2")]
[assembly: RegisterSection(ComponentIdentifiers.THREE_COLUMN_SECTION, "3 columns - 33/33/33", customViewName: "~/Components/Sections/_Kickstart_ThreeColumnSection.cshtml", Description = "Three-column section with zones layout 33% + 33% + 33%.", IconClass = "icon-l-cols-3")]
[assembly: RegisterSection(ComponentIdentifiers.FOUR_COLUMN_SECTION, "4 column 25/25/25/25", customViewName: "~/Components/Sections/_Kickstart_FourColumnSection.cshtml", Description = "Four-column section with zones layout 25% + 25% + 25% + 25%.", IconClass = "icon-l-cols-4")]

// Page templates
[assembly: RegisterPageTemplate(
    identifier: ComponentIdentifiers.LANDING_PAGE_TEMPLATE,
    name: "Landing page content type template",
    customViewName: "~/PageTemplates/LandingPage/LandingPageTemplate.cshtml",
    ContentTypeNames = [LandingPage.CONTENT_TYPE_NAME],
    IconClass = "xp-market")]