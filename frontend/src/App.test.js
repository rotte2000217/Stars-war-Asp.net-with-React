import React from "react";
import renderer from "react-test-renderer";
import App from "./App";
import Question3 from "./question3";
import Question4 from "./question4";

import Enzyme, { shallow, render, mount } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

Enzyme.configure({ adapter: new Adapter() })

describe("App", () => {
  test("snapshot renders App", () => {
    const component = renderer.create(<App />);
    let tree = component.toJSON();
    expect(tree).toMatchSnapshot();
  });
});

describe("Question3", () => {
  test("snapshot renders Question3", () => {
    const component = renderer.create(<Question3 />);
    let tree = component.toJSON();
    expect(tree).toMatchSnapshot();
  });
});

describe("Question4", () => {
  test("snapshot renders Question4", () => {
    const component = renderer.create(<Question4 />);
    let tree = component.toJSON();
    expect(tree).toMatchSnapshot();
  });
});

test('Q3', () => {
  const wrapper = mount(<Question3 />)
  expect(wrapper.instance().state.Question).toBe('What species appeared in the most  number of Star Wars films?');
});

test('Q4', () => {
  const wrapper = mount(<Question4 />)
  expect(wrapper.instance().state.Question).toBe('What planet in Star Wars universe provided largest number of vehicle pilots?');
});

describe('<h2 />', () => {
  it('renders App h2', () => {
    const wrapper = shallow(<App />);
    const elem = wrapper.find('h2');
    expect(elem.length).toBe(2);
  });
});

describe('<div />', () => {
  it('renders App div', () => {
    const wrapper = shallow(<App />);
    const elem = wrapper.find('div');
    expect(elem.length).toBe(2);
  });
});

describe('<h3 />', () => {
  it('renders h3 count', () => {
    const wrapper = shallow(<App />);
    const elem = wrapper.find('h3');
    expect(elem.length).toBe(2);
  });
});

 it('able to find an html element Q3', () => {
  const wrapper = shallow(<Question3 />);
  expect(wrapper.find('h2').html()).toContain('What species appeared');
 });

 it('able to find an html element Q4', () => {
  const wrapper = shallow(<Question4 />);
  expect(wrapper.find('h2').html()).toContain('What planet in Star');
 });

 it('able to find an html element by class App', () => {
  const wrapper = shallow(<App />);
  expect(wrapper.find('.App-logo').html())
   .toContain('Star_Wars_Logo');
 });

 it('able to find an html element by class Q3', () => {
  const wrapper = shallow(<Question3 />);
  expect(wrapper.find('.App-Theme').html())
   .toContain('What species appeared');
 });

 it('able to find an html element by class Q4', () => {
  const wrapper = shallow(<Question4 />);
  expect(wrapper.find('.App-Theme').html())
   .toContain('What planet in Star');
 });

 it('able to find an html element by id Q4', () => {
  const wrapper = shallow(<Question4 />);
  expect(wrapper.find('#QuestionText').html())
   .toContain('What planet in Star');
 });

 it('able to find a React Component Q3', () => {
  const wrapper = shallow(<App />);
  expect(wrapper.find(Question3).length).toBe(1);
 });

 it('able to find a React Component Q4', () => {
  const wrapper = shallow(<App />);
  expect(wrapper.find(Question4).length).toBe(1);
 });
