import React from "react";
import ReactDOM from "react-dom";
import renderer from "react-test-renderer";
import App from "./App";
import Question3 from "./question3";
import Question4 from "./question4";

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
