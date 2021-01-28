import { BoilerplateTemplatePage } from './app.po';

describe('Boilerplate App', function() {
  let page: BoilerplateTemplatePage;

  beforeEach(() => {
    page = new BoilerplateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
