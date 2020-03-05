import React from "react";
import renderer from "react-test-renderer";
import App from "./App";
import Question3 from "./question3";
import Question4 from "./question4";

import Enzyme, { shallow, render, mount } from 'enzyme';
import toJson from 'enzyme-to-json';
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
